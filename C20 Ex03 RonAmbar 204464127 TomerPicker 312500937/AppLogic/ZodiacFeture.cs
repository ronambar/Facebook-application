using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace AppLogic
{
    public class ZodiacFeture //mechanism
    {
        public IZodiacStrategy ZodiacStrategy { get; set; }

        public List<User> BuildMatchingList(User i_LoggedInUser, string i_ZodiacMatch)
        {
            List<User> matchingList = new List<User>();

            matchingZodiacSignFriends(i_LoggedInUser, i_ZodiacMatch, matchingList);

            return matchingList;
        }

        private void matchingZodiacSignFriends(User i_LoggedInUser,string i_ZodiacSign, List<User> i_MatchingList)
        {
            eZodiacSign chosenZoidacSign = (eZodiacSign)Enum.Parse(typeof(eZodiacSign), i_ZodiacSign);
            int startDayRange, endDayRange, startMonthRange, endMonthRange;

            switch (chosenZoidacSign)
            {
                case eZodiacSign.Aguarius:
                    {
                        startDayRange = 20; endDayRange = 18;
                        startMonthRange = 1; endMonthRange = 2;
                        break;
                    }
                case eZodiacSign.Pisces:
                    {
                        startDayRange = 19; endDayRange = 20;
                        startMonthRange = 2; endMonthRange = 3;
                        break;
                    }
                case eZodiacSign.Aries:
                    {
                        startDayRange = 21; endDayRange = 19;
                        startMonthRange = 3; endMonthRange = 4;
                        break;
                    }
                case eZodiacSign.Taurus:
                    {
                        startDayRange = 20; endDayRange = 20;
                        startMonthRange = 4; endMonthRange = 5;
                        break;
                    }
                case eZodiacSign.Gemini:
                    {
                        startDayRange = 21; endDayRange = 20;
                        startMonthRange = 5; endMonthRange = 6;
                        break;
                    }
                case eZodiacSign.Cancer:
                    {
                        startDayRange = 21; endDayRange = 22;
                        startMonthRange = 6; endMonthRange = 7;
                        break;
                    }
                case eZodiacSign.Leo:
                    {
                        startDayRange = 23; endDayRange = 22;
                        startMonthRange = 7; endMonthRange = 8;
                        break;
                    }
                case eZodiacSign.Virgo:
                    {
                        startDayRange = 23; endDayRange = 22;
                        startMonthRange = 8; endMonthRange = 9;
                        break;
                    }
                case eZodiacSign.Libra:
                    {
                        startDayRange = 23; endDayRange = 22;
                        startMonthRange = 9; endMonthRange = 10;
                        break;
                    }
                case eZodiacSign.Scorpio:
                    {
                        startDayRange = 23; endDayRange = 21;
                        startMonthRange = 10; endMonthRange = 11;
                        break;
                    }
                case eZodiacSign.Sagittarius:
                    {
                        startDayRange = 22; endDayRange = 21;
                        startMonthRange = 11; endMonthRange = 12;
                        break;
                    }
                default:
                    {
                        startDayRange = 0; endDayRange = 0;
                        startMonthRange = 0; endMonthRange = 0;
                        break;
                    }
            }

            collectMatchingZodiacSignsFriends(i_LoggedInUser, i_MatchingList, startDayRange, endDayRange, startMonthRange, endMonthRange);
        }

        private void collectMatchingZodiacSignsFriends(User i_LoggedInUser, List<User> i_MatchingList, int i_StartDAy, int i_EndDAy,
            int i_StartMonth, int i_EndMonth)
        {
            for(int i = 0; i < i_LoggedInUser.Friends.Count; i++ )
            {
                if(ZodiacStrategy.ShouldAdd(i_LoggedInUser.Friends[i], i_StartDAy, i_EndDAy, i_StartMonth, i_EndMonth))
                {
                    i_MatchingList.Add(i_LoggedInUser.Friends[i]);
                }
            }
        
        }
       
        public enum eZodiacSign
        {
            Aguarius = 0,
            Pisces = 1,
            Aries = 2,
            Taurus = 3,
            Gemini = 4,
            Cancer = 5,
            Leo = 6,
            Virgo = 7,
            Libra = 8,
            Scorpio = 9,
            Sagittarius = 10,
            Capricorn = 11
        }


    }
}
