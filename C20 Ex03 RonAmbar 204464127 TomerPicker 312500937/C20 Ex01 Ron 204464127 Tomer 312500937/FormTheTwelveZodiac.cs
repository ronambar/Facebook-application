using AppLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    public partial class FormTheTwelveZodiac : Form
    {
        private User m_LoggedInUser;
        private LogicManager m_LogicManager = new LogicManager();
        private readonly string[] r_GenderAnswers = { "female", "male" };
        private readonly string[] r_AgeRangeAnswers = { "18-24", "25-30", "31-37", "38-44", "45-50", "51 and up" };
        private readonly string[] r_FindMatchQuestions =
        {
            " Which gender are you intrested in? ",
            " which age range are you intrested in? "
        };
        private int m_QuestionNumber = 1;
        private int m_CurrentMatchIndex = 0;
        private string m_UserChosenZodiacSign;
        private string m_UserChosenGender;
        private Point m_UserChosenAgeRange;
        private IEnumerator<User> m_UsersIterator;

        public FormTheTwelveZodiac()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            this.m_LoggedInUser = SingletonLoggedInUser.Instance.LoggedInUser;
            this.theTwelveZodiacLable.BackColor = Color.Transparent;
            this.questionLabel.BackColor = Color.Transparent;         
        }

        private void formTheTwelveZodiac(object sender, EventArgs e) { }

        public enum eQuestionSubject
        {
            Zodiac = 0,
            Gender = 1,
            AgeRange = 2,
            Done = 4
        }

        private void questionLabel_Click(object sender, EventArgs e)
        { }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            eQuestionSubject eQuestionSubject = eQuestionSubject.Zodiac;

            switch (m_QuestionNumber)
            {
                case 1:
                    {
                        eQuestionSubject = eQuestionSubject.Gender;
                        break;
                    }
                case 2:
                    {
                        eQuestionSubject = eQuestionSubject.AgeRange;
                        break;
                    }
                case 3:
                    {
                        eQuestionSubject = eQuestionSubject.Done;
                        break;
                    }
            }

            collectUserAnswers();
            m_QuestionNumber++;
            initializeNextQuestionAndAnswers(eQuestionSubject);
        }

        private void initializeNextQuestionAndAnswers(eQuestionSubject i_QuestionSubject)
        {
            switch (i_QuestionSubject)
            {
                case eQuestionSubject.Gender:
                    {
                        questionLabel.Text = r_FindMatchQuestions[0];
                        answersListBox.Items.Clear();
                        answersListBox.Items.AddRange(r_GenderAnswers);
                        answersListBox.Text = r_GenderAnswers[0];
                        break;
                    }
                case eQuestionSubject.AgeRange:
                    {
                        questionLabel.Text = r_FindMatchQuestions[1];
                        answersListBox.Items.Clear();
                        answersListBox.Items.AddRange(r_AgeRangeAnswers);
                        answersListBox.Text = r_AgeRangeAnswers[0];
                        break;
                    }
                case eQuestionSubject.Done:
                    {
                        m_LogicManager.FindMatchingFriendsList(m_UserChosenZodiacSign, m_UserChosenGender, m_UserChosenAgeRange);
                        createShowMatchingFriendsButton();
                        break;
                    }
            }
        }

        private void collectUserAnswers()
        {
            int selectedAnswerIndex = answersListBox.SelectedIndex;

            try
            {
                switch (m_QuestionNumber)
                {
                    case 1:
                        {
                            m_UserChosenZodiacSign = answersListBox.Items[selectedAnswerIndex].ToString();
                            break;
                        }
                    case 2:
                        {
                            m_UserChosenGender = answersListBox.Items[selectedAnswerIndex].ToString();
                            break;
                        }
                    case 3:
                        {
                            m_UserChosenAgeRange = convertAgeRangeAnswerToValues(selectedAnswerIndex);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                backMainApp();
            }
        }

        private Point convertAgeRangeAnswerToValues(int i_SelectedAgeRange)
        {
            int minAge = 0, maxAge = 0;

            switch (i_SelectedAgeRange)
            {
                case 0:
                    {
                        minAge = 18;
                        maxAge = 24;
                        break;
                    }
                case 1:
                    {
                        minAge = 25;
                        maxAge = 30;
                        break;
                    }
                case 2:
                    {
                        minAge = 31;
                        maxAge = 37;
                        break;
                    }
                case 3:
                    {
                        minAge = 38;
                        maxAge = 44;
                        break;
                    }
                case 4:
                    {
                        minAge = 45;
                        maxAge = 50;
                        break;
                    }
                case 5:
                    {
                        minAge = 51;
                        maxAge = 100;
                        break;
                    }
            }

            Point ageRange = new Point(minAge, maxAge);

            return ageRange;
        }

        private void createShowMatchingFriendsButton()
        {
            m_UsersIterator = m_LogicManager.GetEnumerator();
            unVisibleControllers();
            theTwelveZodiacLable.Visible = true;
            backButton.Visible = true;
            gamePicture.Visible = true;
            theTwelveZodiacLable.Text = "Are you ready to see your matches?";
            theTwelveZodiacLable.Font = new Font("Segoe UI Semibold", 20);
            theTwelveZodiacLable.Location = new Point(144, 50);
            theTwelveZodiacLable.BackColor = Color.Transparent;
            this.showResultsButton.Visible = true;
            this.showResultsButton.Location = new Point(250, 200);
        }

        private void loadMatchingFriendsPage()
        {
            this.matchedFriendsProfilePicture.Visible = true;
            loadMatchedFriendsControls();
        }

        private void answersZodiacBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backMainApp();
        }

        private void backMainApp()
        {
            MainAppForm backForm = new MainAppForm();
            backForm.StartPosition = FormStartPosition.Manual;
            backForm.Location = this.Location;
            this.Hide();
            backForm.ShowDialog();
            this.Close();
        }

        private void loadMatchedFriendsControls()
        {
            if (m_UsersIterator.MoveNext())
            {
                userBindingSource.DataSource = m_UsersIterator.Current;
                this.matchedFriendsProfilePicture.Load(m_UsersIterator.Current.PictureNormalURL);
                this.matchedFriendName.Visible = true;
                this.matchedFriendName.Text = string.Format("Name: {0}", m_UsersIterator.Current.Name);
                this.theTwelveZodiacLable.Text = "Your match is:";
                this.theTwelveZodiacLable.Visible = true;
                theTwelveZodiacLable.BackColor = Color.Transparent;
                nextMatchButton.Visible = true;
            }
          
            else
            {
                unVisibleControllers();
                backButton.Visible = true;
                gamePicture.Visible = true;
                loadGoodByeLabel();
            }
        }

        private void unVisibleControllers()
        {
            foreach (Control currentControl in this.Controls)
            {
                currentControl.Visible = false;
            }
        }

        private void loadGoodByeLabel()
        {
            Label endGameLabel = new Label();

            this.Controls.Add(endGameLabel);
            endGameLabel.Parent = this.gamePicture;
            endGameLabel.BackColor = Color.White;
            endGameLabel.Location = matchedFriendsProfilePicture.Location;
            endGameLabel.Left -= 200;
            endGameLabel.Font = new Font("Segoe UI Semibold", 20);
            endGameLabel.Anchor = AnchorStyles.None;
            endGameLabel.AutoSize = true;
            endGameLabel.ForeColor = Color.Black;

            if (m_CurrentMatchIndex == 0)
            {
                endGameLabel.Text = "Sorry, we didn't find any match for you";
                endGameLabel.Left += 100;
            }
            else
            {
                endGameLabel.Text = "That's all, Hope you will find the one for you!";
            }
        }

        private void matchedFriendsProfilePicture_Click(object sender, EventArgs e)
        { }

        private void showResultsButton_Click_1(object sender, EventArgs e)
        {
            this.showResultsButton.Visible = false;
            theTwelveZodiacLable.Visible = false;
            loadMatchingFriendsPage();
        }

        private void nextMatchButton_Click_1(object sender, EventArgs e)
        {
            loadMatchedFriendsControls();
        }
    }
}
