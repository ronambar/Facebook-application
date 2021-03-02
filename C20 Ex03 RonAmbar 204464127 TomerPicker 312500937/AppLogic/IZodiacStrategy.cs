using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public interface IZodiacStrategy
    {
        bool ShouldAdd(User i_CurrentFriend, int i_StartDAy, int i_EndDAy, int i_StartMonth, int i_EndMonth);
    }
}
