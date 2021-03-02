using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using FacebookWrapper.ObjectModel;


namespace AppLogic
{
    public class ChosenZodiacStrategy : IZodiacStrategy
    {
        public bool ShouldAdd(User i_CurrentFriend, int i_StartDAy, int i_EndDAy, int i_StartMonth, int i_EndMonth)
        {
            DateTime friendBirthday;
            string friendBirthdayString;
            bool shouldAdd = false;

            friendBirthdayString = i_CurrentFriend.Birthday;
            if (DateTime.TryParseExact
                (friendBirthdayString,"MM/dd/yyyy", new CultureInfo("es-US"), DateTimeStyles.None, out friendBirthday))
            {
                if ((friendBirthday.Month == i_StartMonth && friendBirthday.Day >= i_StartDAy) ||
                   (friendBirthday.Month == i_EndMonth && friendBirthday.Day <= i_EndDAy))
                {
                    shouldAdd = true;
                }
            }

            return shouldAdd;
        }
    }
}
