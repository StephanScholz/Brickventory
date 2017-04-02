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
using Brickinventory.Classes.Session;

namespace BrickventoryApp
{
    [Activity(Label = "SetLists")]
    public class SetListViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SetListView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar4);
            //Toolbar will now take on default Action Bar characteristics
            SetActionBar(toolbar);
            //You can now use and reference the ActionBar
            ActionBar.Title = "Brickventory";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);
            return base.OnPrepareOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.nav_logout:
                    UserSession.GetInstance().Logout();
                    StartActivity(typeof(LoginActivity));
                    break;
                /*case Resource.Id.new_game:
                    //do something
                    return true;
                case Resource.Id.help:
                    //do something
                    return true;*/
            }
            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            if (UserSession.GetInstance().isUserLoggedIn())
                return;
            base.OnBackPressed();
        }
    }
}