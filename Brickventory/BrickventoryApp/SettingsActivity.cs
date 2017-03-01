using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BrickventoryApp
{
    [Activity(Label = "Settings")]
    public class SettingsActivity : Activity
    {
        EditText api_input;
        string filename = "api";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Settings);
            Button save = FindViewById<Button>(Resource.Id.useThisApiKey_button);
            save.Click += Save_Click;
            api_input = FindViewById<EditText>(Resource.Id.apiInput);
            LoadApiKey();
        }

        private void LoadApiKey()
        {
            //StreamReader sr = new StreamReader(filename, false);
            //api_input.Text = sr.ReadLine();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "API-Key gespeichert. Haha, also ob!", ToastLength.Short).Show();
            try
            {
                StreamWriter sw = new StreamWriter(filename, false);
                sw.WriteLine(api_input.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long);
            }

        }

        //protected override void OnStart()
        //{
        //    base.OnStart();
        //}
    }
}