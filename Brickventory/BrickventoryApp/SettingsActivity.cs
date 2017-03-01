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
    [Activity(Label = "Settings")]
    public class SettingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Settings);
            TextView t = FindViewById<TextView>(Resource.Id.textView1);
            EditText e = FindViewById<EditText>(Resource.Id.apiInput);
            //SetContentView(Resource.Layout.);
        }

        
        protected override void OnStart()
        {
           
        }
    }
}