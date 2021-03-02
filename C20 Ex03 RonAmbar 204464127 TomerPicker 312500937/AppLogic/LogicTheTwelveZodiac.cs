using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections;

namespace AppLogic
{
    internal class LogicTheTwelveZodiac
    {
        private User m_LoggedInUser { get; set; }
        public ZodiacFeture m_ZodiacFeture { get; set; }
        internal List<User> m_MatchingFriendsList = new List<User>();

        internal LogicTheTwelveZodiac()
        {
            m_LoggedInUser = SingletonLoggedInUser.Instance.LoggedInUser;
            m_ZodiacFeture = new ZodiacFeture() { ZodiacStrategy = new ChosenZodiacStrategy() };
        }

        public List<User> MatchedList
        {
            get
            {
                return m_MatchingFriendsList;
            }
        }

        internal void BuildMatchingZodiacList(string i_ZodiacSign)
        {
            m_MatchingFriendsList = m_ZodiacFeture.BuildMatchingList(m_LoggedInUser, i_ZodiacSign);
        }

        internal void RemoveUnmatchingGenderFriends(string i_Gender)
        {
            try
            {
                for (int i = 0; i < m_MatchingFriendsList.Count; i++)
                {
                    if (m_MatchingFriendsList[i].Gender.ToString() != i_Gender)
                    {
                        m_MatchingFriendsList.RemoveAt(i);
                        i--;
                    }
                }
            }
            catch { }
        }

        internal void RemoveUnmatchingAgeFriends(Point i_AgeRange)
        {
            try
            {
                DateTime friendBirthday;
                string friendBirthdayString;
                int friendAge;

                for (int i = 0; i < m_MatchingFriendsList.Count; i++)
                {
                    friendBirthdayString = m_LoggedInUser.Friends[i].Birthday;
                    if (DateTime.TryParse(friendBirthdayString, out friendBirthday))
                    {
                        friendAge = DateTime.Today.Year - friendBirthday.Year;
                        if (friendAge < i_AgeRange.X || friendAge > i_AgeRange.Y)
                        {
                            m_MatchingFriendsList.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            catch { }
        }

        public enum eGender
        {
            female = 0,
            male = 1
        }
    }
}
