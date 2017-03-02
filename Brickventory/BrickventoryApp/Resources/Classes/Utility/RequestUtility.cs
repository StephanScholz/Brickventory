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

// A Utility-Class, that makes Access and Usage of WebRequests easier
namespace BrickventoryApp.Resources.classes.Utility
{
    public static class RequestUtility
    {

        private const string API_KEY = "?key=faaf91147e37117cfe0d94519f8fde41";

        public static string Create_UserToken(string username, string password)
        {
            string parameters = "username=" + username + "&password=" + password;

            return POST_Request("http://rebrickable.com/api/v3/users/_token/" + API_KEY, parameters);
        }
        
        private static string POST_Request(string url, string parameters)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "application/json";
            request.UseDefaultCredentials = true;

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

    }
}