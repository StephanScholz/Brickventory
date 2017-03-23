using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using BrickventoryApp.Resources.classes.Utility;

namespace Brickinventory.Classes.Session
{
    public sealed class UserSession
    {
        private static UserSession instance;
        public UserData userData { get; set; }

        static UserSession()
        {
        }

        private UserSession()
        {
        }

        public static UserSession Create()
        {
            if (instance == null)
                instance = new UserSession();

            return instance;
        }

        public bool Login(string username, string password)
        {
            if (userData != null)
                userData = null;
            
            userData = JsonConvert.DeserializeObject<UserData>(RequestUtility.Create_UserToken(username, password));
            if(userData != null && !userData.user_token.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}