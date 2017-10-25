using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Android.Support.V4.Widget;
using careBeyond_App.Controller;
using System.Collections.Generic;
using Android.Util;
using System.Threading.Tasks;
using Android.Widget;
using careBeyond_App.Model;
using System.Collections;

namespace careBeyond_App
{
    [Activity(Label = "CareBeyond Mobile", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        DrawerLayout drawerLayout;
        Android.Support.V7.Widget.Toolbar toolbar;
        NavigationView navigationView;
        TextView mainTV;
        private static string TAG = "MainActivity";
        List<caregiver_model> listCaregiver;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_list);

            navigationView = FindViewById<NavigationView>(Resource.Id.navLayout);
            navigationView.NavigationItemSelected += NavView_NavigationItemSelected;

           
        }

        private void NavView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            e.MenuItem.SetChecked(true);
            switch (e.MenuItem.ItemId)
            {
                case Resource.Id.todaySchedule_menu:
                    break;
                case Resource.Id.clientList_menu:
                    break;
                case Resource.Id.calendar_menu:
                    break;
                case Resource.Id.inbox_menu:
                    break;
                case Resource.Id.alert_menu:
                    break;
                case Resource.Id.newContact_menu:
                    break;
                case Resource.Id.sync_menu:
                    break;
                case Resource.Id.settings_menu:
                    break;
                case Resource.Id.logout_menu:
                    break;
            }
            Snackbar.Make(drawerLayout, "Menu " + e.MenuItem.TitleFormatted+ "will be available soon!", Snackbar.LengthLong).Show();
            drawerLayout.CloseDrawers();

        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}

