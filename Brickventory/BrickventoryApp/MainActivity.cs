using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace BrickventoryApp
{
    [Activity(Label = "BrickventoryApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.Title = "Brickventory";
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }

        public void Connect_OnClick()
        {
            
        }
    }
}

