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
using UserData;
using Newtonsoft.Json;

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
            Create_UserToken();
        }

        private void Create_UserToken()
        {
            string username, password;
            username = FindViewById<EditText>(Resource.Id.tf_username).Text;
            password = FindViewById<EditText>(Resource.Id.tf_password).Text;
            Toast.MakeText(this, "user: " + username + ", pw: " + password, ToastLength.Long).Show();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://rebrickable.com/api/v3/users/_token/?key=faaf91147e37117cfe0d94519f8fde41");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "application/json";
            string parameters = "username=" + username + "&password=" + password;

            using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(parameters);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                User user = JsonConvert.DeserializeObject<User>(result);
                Toast.MakeText(this, "usertoken: " + user.user_token, ToastLength.Long);
            }
        }
    }

}