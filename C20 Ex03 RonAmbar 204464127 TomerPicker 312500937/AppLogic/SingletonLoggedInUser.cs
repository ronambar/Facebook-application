using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using System.Reflection;
using SingletonT;

namespace AppLogic
{
    public sealed class SingletonLoggedInUser
    {
        private User s_LoggedInUser = null;

        private SingletonLoggedInUser()
        {
            login();
        }

        public User LoggedInUser
        {
            get
            {
                if (s_LoggedInUser == null)
                {
                    login();
                }

                return s_LoggedInUser;
            }

            private set
            {
                s_LoggedInUser = value;
            }
      } 

        public static SingletonLoggedInUser Instance
        {
            get
            {
                return Singleton<SingletonLoggedInUser>.Instance;
            }            
        }

        private void login()
        {
            LoginResult result = null;

            result = FacebookService.Login("352514576146047",
            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"
            );


            if (!string.IsNullOrEmpty(result.AccessToken))
            {                
                LoggedInUser = new User();
                LoggedInUser = result.LoggedInUser;
            }
            else
            {
                throw new Exception("App didn't receive access to your Facebook account");
            }
        }

        public void Logout()
        {            
            FacebookService.Logout();
            s_LoggedInUser = null;
        }

    }
}


