using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public class LogicTriviaGame
    {
        public User m_LoggedInUser { get; private set; }
        public User m_CurrentAskedUser { get; private set; }
        public int m_CurrentRightAnswerIndex { get; private set; }
        public eQuestionSubject m_CurrentQuestionSubject { get; private set; }
        public List<string> m_CurrentAnswers = new List<string>(4);
        public int m_Score { get; private set; }
        public int m_QuestionNumber { get; private set; }
        private Random random = new Random();

        private readonly List<string> r_NamesList = new List<string>
        {
              "The user doesn't have Name in his account",
            "Bar Refaeli",
            "Gal Gadot",
            "Moran Atias",
            "Ben Sahar",
            "Andres Iniesta",
            "Paolo Maldini",
            "Ronaldinho",
            "Marco van Basten",
            "Ronaldo Nazário",
            "Zinedine Zidane",
            "Cristiano Ronaldo",
            "Diego Maradona",
            "Lionel Messi",
            "Katy Perry",
            "Miley Cyrus",
            "Kim Kardashian",
            "Nicki Minaj",
            "Jennifer Lopez",
            "Kendall Jenner",
            "Taylor Swift",
            "Justin Bieber",
            "Beyoncé",
            "Selena Gomez",
            "Kylie Jenner",
            "Dwayne Johnson",
            "Ariana Grande",
            "Esti Ginzburg",
        };

        private readonly List<string> r_HometowensList = new List<string>
        {
            "The user doesn't have Hometowen in his account",
            "Rehovot",
            "Ashdod",
            "Tel Aviv",
            "Jaffo",
            "Ramat HaSharon",
            "Afula",
            "Segoe UI Semibold",
            "Ashkelon",
            "Beersheba",
            "Eilat",
            "Giv'atayim",
            "Hadera",
            "Hod HaSharon",
            "Jerusalem",
            "Karmiel",
            "Kiryat Shmona",
            "Modi'in",
            "Maccabim-Re'ut",
            "Netanya",
            "Netivot",
            "Or Yehuda",
            "Ra'anana",
            "Ramat Gan",
            "Rishon LeZion",
            "Rosh HaAyin",
            "Tiberias",
            "Yavne",
            "Kefar Sava",
            "Lod",
            "H̱olon",
            "Dimona",
            "Asseret",
            "Gderot",
        };

        private readonly List<string> r_CheckinsList = new List<string>
        {
            "The user doesn't have Checkin in his account",
            "Morro de São Paulo",
            "Cataratas Do Iguaçu",
            "Jericoacoara Beach",
            "`Aseret, Hamerkaz, Israel",
            "Selena Eilat",
            "Babcha Bar, ‎Negbah ",
            "Park Ra'anana",
            "Nizanim, Hadarom, Israel",
            "Carretera Austral",
            "Club-In Eilat",
            "Funjoya Eilat",
            "Laguna De Siete Colores, Bacalar",
            "Panajachel, Solola",
            "San Pedro La Laguna",
            "San Cristobal Pueblo Magico Chiapas",
            "Koh Phi Phi Beach, Thailand",
           "Koh Samui, Thailand",
           "Mamilla Avenue, Jerusalem",
           "Camp Nou (FC Barcelona)",
           "Bugrashov Beach",
           "Salar De Uyuni - Bolivia",
           "Porito Moreno , El Calafate",
           "Ausangate Trek,Cusco,Perú ",
           "Machu Picchu,Cusco,Perú",
           "Loki Cusco, Perú",
           "Volcano Acatenango,Guatemala",
           "Mush beach Eilat",
            "American Niagara Falls",
        };

        private readonly List<string> r_QuestionList = new List<string>
        {
            "What's the birthday of the friend in the picture?",
            "What's the name of the friend in the picture?",
            "What's the hometowen of the friend in the picture?",
            "What's the last checkin of the friend in the picture?",
        };

        public List<string> QuestionList
        {
            get
            {
                return r_QuestionList;
            }
        }

        public List<string> CurrentAnswers
        {
            get
            {
                return m_CurrentAnswers;
            }
        }

        public LogicTriviaGame()
        {
            this.m_LoggedInUser = SingletonLoggedInUser.Instance.LoggedInUser;
            this.m_Score = 0;
            this.m_QuestionNumber = 1;
        }

        public void CreateTurn()
        {
            chooseAndUpdateQuestionSubject();
            chooseAndUpdateCurrentAskedUser();
            updateCurrentAnswers();
        }

        public void FinishTurn(int i_UserChoice)
        {
            if(i_UserChoice == this.m_CurrentRightAnswerIndex + 1)
            {
                this.m_Score++;
            }

            m_QuestionNumber++;
        }

        private void chooseAndUpdateQuestionSubject()
        {
            eQuestionSubject newQuestionSubject = m_CurrentQuestionSubject;
            while (m_CurrentQuestionSubject == newQuestionSubject)
            {
                newQuestionSubject = (eQuestionSubject)random.Next(0, r_QuestionList.Count); ;
            }

            m_CurrentQuestionSubject = newQuestionSubject;
        }

        private void chooseAndUpdateCurrentAskedUser()
        {
            int randAskedUser = random.Next(0, m_LoggedInUser.Friends.Count);
            m_CurrentAskedUser = m_LoggedInUser.Friends[randAskedUser];
        }

        private void updateCurrentAnswers()
        {
            bool isInserted = false;

            m_CurrentAnswers.Clear();
            intiallizeAnswerFromUserData(m_CurrentAskedUser, 0);
            for (int i = 1; i < m_CurrentAnswers.Capacity ; i++)
            {
                isInserted = false; //for the next loop
                while (isInserted == false)
                {
                    isInserted = intiallizeRundumAnsewrsBySubject(i);
                }
            }

            locateRightAnswer();
        }

        private bool intiallizeAnswerFromUserData(User i_User, int i_IndexToInsert)
        {
            bool result = false;
            string userDataAnswer = null;

            try
            {
                switch (m_CurrentQuestionSubject)
                {
                    case eQuestionSubject.Birthday:
                        {
                            if (string.IsNullOrEmpty(i_User.Birthday) == false)
                            {
                                userDataAnswer = i_User.Birthday;
                            }
                            break;
                        }
                    case eQuestionSubject.Name:
                        {
                            if (string.IsNullOrEmpty(i_User.Name) == false)
                            {
                                userDataAnswer = i_User.Name;
                            }
                            break;
                        }
                    case eQuestionSubject.Hometown:
                        {
                            if (i_User.Hometown != null && string.IsNullOrEmpty(i_User.Hometown.Name) == false)
                            {
                                userDataAnswer = i_User.Hometown.Name;
                            }
                            break;
                        }
                    case eQuestionSubject.Checkin:
                        {
                            if (i_User.Checkins != null && i_User.Checkins.Count > 0)
                            {
                                userDataAnswer = i_User.Checkins[0].Place.Name;
                            }
                            break;
                        }
                }
            }
            catch
            {
                userDataAnswer = string.Format("The user doesn't have {0} in his account", m_CurrentQuestionSubject.ToString());
            }

            if (userDataAnswer == null)
            {
                userDataAnswer = string.Format("The user doesn't have {0} in his account", m_CurrentQuestionSubject.ToString());
            }

            if (isFriendAnswerAlreadyExist(userDataAnswer, i_IndexToInsert) == false)
            {
                m_CurrentAnswers.Add(userDataAnswer);
                result = true;
            }

            return result;
        }

        private bool isFriendAnswerAlreadyExist(string i_FriendData, int i_LastElementInserted)
        {
            bool isExist = false;
            for (int i = 0; i < i_LastElementInserted; i++)
            {
                if (i_FriendData.Equals(m_CurrentAnswers[i]) == true)
                {
                    isExist = true;
                }
            }
            return isExist;
        }
        
        private void locateRightAnswer()
        {
            m_CurrentRightAnswerIndex = random.Next(0, m_CurrentAnswers.Capacity - 1);
            SwapElementsInList(m_CurrentAnswers,0, m_CurrentRightAnswerIndex);
        }

        public static void SwapElementsInList<T> (List<T> i_List,int i_FirstIndex, int i_SecIndex)
        {
            T temp = i_List[i_FirstIndex];
            i_List[i_FirstIndex] = i_List[i_SecIndex];
            i_List[i_SecIndex] = temp;
            
        }

        private bool intiallizeRundumAnsewrsBySubject(int i_IndexToInsert)
        {
            bool result = false;
            string userDataAnswer = createRundumAnsewrsBySubject();
            
            if (isFriendAnswerAlreadyExist(userDataAnswer, i_IndexToInsert) == false)
            {               
                m_CurrentAnswers.Add(userDataAnswer);
                result = true;
            }

            return result;
        }

        private string createRundumAnsewrsBySubject()
        {
            string userDataAnswer = null;

            switch (m_CurrentQuestionSubject)
            {
                case eQuestionSubject.Birthday:
                    {
                        userDataAnswer = createBirthdayAnsewrStr();
                        break;
                    }
                case eQuestionSubject.Name:
                    {
                        userDataAnswer = createNameAnsewrStr();
                        break;
                    }
                case eQuestionSubject.Hometown:
                    {
                        userDataAnswer = createHometownAnsewrStr();
                        break;
                    }
                case eQuestionSubject.Checkin:
                    {
                        userDataAnswer = createCheckinAnsewrStr();
                        break;
                    }
            }

            return userDataAnswer;
        }

        private string createNameAnsewrStr()
        {
            int currentNameIndex = random.Next(0, r_NamesList.Count - 1);
            return r_NamesList[currentNameIndex];

        }

        private string createBirthdayAnsewrStr()
        {
            int dayOfBirth = random.Next(1, 30);
            int monthOfBirth = random.Next(1, 12);
            int yearOfBirth = random.Next(1980, 2000);
            StringBuilder dayOfBirthStr = new StringBuilder(dayOfBirth.ToString());

            if (dayOfBirthStr.Length == 1)
            {
                dayOfBirthStr.Insert(0,"0");
            }
           
            StringBuilder monthOfBirthStr = new StringBuilder(monthOfBirth.ToString());
            if (monthOfBirthStr.Length == 1)
            {
                monthOfBirthStr.Insert(0, "0");
            }

            return string.Format("{0}/{1}/{2}", monthOfBirthStr, dayOfBirthStr, yearOfBirth);
        }

        private string createHometownAnsewrStr()
        {
            int currentHometowenIndex = random.Next(0, r_HometowensList.Count - 1);

            return r_HometowensList[currentHometowenIndex];            
        }

        private string createCheckinAnsewrStr()
        {
            int currentCheckinIndex = random.Next(0, r_CheckinsList.Count - 1);

            return r_CheckinsList[currentCheckinIndex];
        }

        public enum eQuestionSubject
        {
            Birthday = 0,
            Name = 1,
            Hometown = 2,
            Checkin = 3
        }
    }
}

