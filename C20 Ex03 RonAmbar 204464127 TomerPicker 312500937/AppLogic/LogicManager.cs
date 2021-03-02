using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace AppLogic
{
    public class LogicManager : IEnumerable<User>
    {
        private LogicTheTwelveZodiac m_LogicTheTwelveZodiac;

        public LogicManager()
        {
            createZodiacLogic();
        }

        private void createZodiacLogic()
        {
            m_LogicTheTwelveZodiac = new LogicTheTwelveZodiac();
        }

        public void FindMatchingFriendsList(string i_ZodiacSign, string i_Gender, Point i_AgeRange)
        {
            m_LogicTheTwelveZodiac.BuildMatchingZodiacList(i_ZodiacSign);
            m_LogicTheTwelveZodiac.RemoveUnmatchingGenderFriends(i_Gender);
            m_LogicTheTwelveZodiac.RemoveUnmatchingAgeFriends(i_AgeRange);

        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User CurrentFriend in m_LogicTheTwelveZodiac.MatchedList)
            {
                yield return CurrentFriend;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
