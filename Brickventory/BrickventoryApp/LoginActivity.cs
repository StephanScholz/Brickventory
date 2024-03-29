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
using System.Net;
using System.IO;
using Newtonsoft.Json;

using BrickventoryApp.Resources.classes.Utility;
using Brickinventory.Classes.Session;

namespace BrickventoryApp
{
    [Activity(Label = "Login")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar3);
            //Toolbar will now take on default Action Bar characteristics
            SetActionBar(toolbar);
            //You can now use and reference the ActionBar
            ActionBar.Title = "Brickventory";
            Button login = FindViewById<Button>(Resource.Id.login_button);
            login.Click += Login_Click;
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            string username = FindViewById<EditText>(Resource.Id.tf_username).Text;
            string password = FindViewById<EditText>(Resource.Id.tf_password).Text;
            UserSession session = UserSession.GetInstance();
            try
            {
                bool loginSuccess = session.Login(username, password);

                if (loginSuccess)
                {
                    Toast.MakeText(this, "Login successful!", ToastLength.Long).Show();
                    Toast.MakeText(this, session.userData.user_token, ToastLength.Long).Show();
                    StartActivity(typeof(SetListViewActivity));
                }
                else
                    Toast.MakeText(this, "Login failed!", ToastLength.Long).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }

        }
    }

}