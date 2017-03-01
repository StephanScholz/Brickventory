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
            Toast.MakeText(this, "Login", ToastLength.Long).Show();
        }
    }

}