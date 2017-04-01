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
using Brickinventory.Classes;

// A Utility-Class, that makes Access and Usage of WebRequests easier
namespace BrickventoryApp.Resources.classes.Utility
{
    public class RequestUtility
    {
        //Stephan
        //private const string API_KEY = "?key=faaf91147e37117cfe0d94519f8fde41";
        //Patrick
        private string apiKey;
        public void SetApiKey(string key)
        {
            apiKey = key;
        }

        private string usersURL = "http://rebrickable.com/api/v3/users/";

        public string Create_UserToken(string username, string password)
        {
            username = WebUtility.UrlEncode(username);
            password = WebUtility.UrlEncode(password);
            string parameters = "username=" + username + "&password=" + password;
            
            return POST_Request(usersURL + "_token/", parameters);
        }

        //Gets all of the users SetLists and saves it (and the inhibiting Sets) into their respective counterpart-classes.
        //Those classes will be safed in a List<T> inside the class SetStorage.
        public string GetSetLists(UserData userData)
        {
            return GET_Request(usersURL + userData.user_token + "/setlists/");
        }
        
        private string POST_Request(string url, string parameters)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            //request.UserAgent = "Mozilla/5.0";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "application/json";
            request.Headers[HttpRequestHeader.Authorization] = "key " + apiKey;
            request.Host = "rebrickable.com";
            request.UseDefaultCredentials = true;
            request.Credentials = CredentialCache.DefaultCredentials;

            using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(parameters);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        private string GET_Request(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "application/json";
            request.Headers[HttpRequestHeader.Authorization] = "key " + apiKey;

            HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }

        }

    }
}