using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;
using System.Net;

namespace BrickventoryApp
{
    [Activity(Label = "Brickventory", MainLauncher = true, Icon = "@drawable/robo3ta")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar1);
            //Toolbar will now take on default Action Bar characteristics
            SetActionBar(toolbar);
            //You can now use and reference the ActionBar
            ActionBar.Title = "Brickventory";
            Button settings = FindViewById<Button>(Resource.Id.settings_button);
            settings.Click += Settings_Click;
            Button connect = FindViewById<Button>(Resource.Id.connect_button);
            connect.Click += Connect_Click;
        }

        private void Connect_Click(object sender, System.EventArgs e)
        {
            //Toast.MakeText(this, "Connect", ToastLength.Short).Show();
            StartActivity(typeof(LoginActivity));

        }

        private void Settings_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(SettingsActivity));
        }
    }
}

