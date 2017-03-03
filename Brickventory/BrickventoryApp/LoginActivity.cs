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
            Button login = FindViewById<Button>(Resource.Id.login_button);
            login.Click += Login_Click;
        }

        private void Login_Click(object sender, System.EventArgs e)
        {
            string username = FindViewById<EditText>(Resource.Id.tf_username).Text;
            string password = FindViewById<EditText>(Resource.Id.tf_password).Text;
            UserSession session = UserSession.Create();
            bool loginSuccess = session.Login(username, password);
            if (loginSuccess)
            {
                Toast.MakeText(this, "Login successful!", ToastLength.Long).Show();
                Toast.MakeText(this, session.userData.user_token, ToastLength.Long).Show();
            }
            else
                Toast.MakeText(this, "Login failed!", ToastLength.Long).Show();


        }
    }

}