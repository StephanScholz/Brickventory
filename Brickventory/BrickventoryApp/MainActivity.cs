using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;

namespace BrickventoryApp
{
    [Activity(Label = "Brickventory", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            Button settings = FindViewById<Button>(Resource.Id.settings_button);
            settings.Click += Settings_Click;
            Button connect = FindViewById<Button>(Resource.Id.connect_button);
            connect.Click += Connect_Click;


        }

        private void Connect_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Connect", ToastLength.Short).Show();
        }

        private void Settings_Click(object sender, System.EventArgs e)
        {
            //Toast.MakeText(this, "Settings", ToastLength.Short).Show();
            SettingsActivity sa = new SettingsActivity();
            Intent i = new Intent(this, sa.Class);
            StartActivity(i);

            //throw new System.NotImplementedException();
        }
    }
}

