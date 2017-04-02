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
using BrickInventory.Classes;
using BrickventoryApp;

namespace Brickinventory.Classes.Session
{
    public sealed class UserSession
    {
        private SetListStorage setListStorage;
        private static UserSession instance;
        public UserData userData { get; set; }
        private RequestUtility reqUtil;
        private bool isLoggedIn = false;
        public bool isUserLoggedIn()
        {
            return isLoggedIn;
        }

        private UserSession()
        {
            reqUtil = new RequestUtility();
        }

        public static UserSession GetInstance()
        {
            if (instance == null)
                instance = new UserSession();

            return instance;
        }
        
        public bool Login(string username, string password)
        {
            if (userData != null)
                userData = null;

            userData = JsonConvert.DeserializeObject<UserData>(reqUtil.Create_UserToken(username, password));
            if(userData != null && !userData.user_token.Equals(""))
            {
                isLoggedIn = true;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            if (userData != null)
                userData = null;
        }

        public void GetSetLists()
        {
            setListStorage = JsonConvert.DeserializeObject<SetListStorage>(reqUtil.GetSetLists(userData));
        }

        public void SetApiKey(string key)
        {
            reqUtil.SetApiKey(key);
        }
    }
}