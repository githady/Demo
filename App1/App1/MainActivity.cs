using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using DemoApp;

namespace App1
{
    [Activity(Label = "DemoAppRelease", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            AppCenter.Start("00806dbd-d7d0-494d-87f5-a2fb5b379727",
                   typeof(Analytics), typeof(Crashes));

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.login);
            // Get our button from the layout resource,
            // and attach an event to it
            EditText txtUsername = FindViewById<EditText>(Resource.Id.username);
            EditText txtPassword = FindViewById<EditText>(Resource.Id.password);
            Button button = FindViewById<Button>(Resource.Id.loginBtn);
            button.Click += delegate
            {
                if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
                {
                    StartActivity(typeof(HomeScreen));
                }
                else
                {
                    Toast.MakeText(this, "Invalid username or password.", ToastLength.Short).Show();
                }
            };

        }
    }
}

