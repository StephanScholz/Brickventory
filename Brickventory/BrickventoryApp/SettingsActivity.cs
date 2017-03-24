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
using Android.Preferences;

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
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this);
            api_input.Text = prefs.GetString("apikey", "none");
        }

        
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this);
                ISharedPreferencesEditor editor = prefs.Edit();
                editor.PutString("apikey", api_input.Text);
                editor.Apply();
                Toast.MakeText(this, "API-Key gespeichert", ToastLength.Long).Show();
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