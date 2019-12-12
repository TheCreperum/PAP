using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace PAP
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.Design", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnCreate = FindViewById<Button>(Resource.Id.btnCreate);
            var btnChoose = FindViewById<Button>(Resource.Id.btnChoose);
            var btnContinueCreate = FindViewById<Button>(Resource.Id.btnContinuePlayers);
            var btnContinueChoose = FindViewById<Button>(Resource.Id.btnContinueTeams);

            btnCreate.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(ChangeLayout));
                StartActivity(nextActivity);
            };

            btnChoose.Click += (s, e) =>
            {
                Intent nextActivity2 = new Intent(this, typeof(ChooseLayout));
                StartActivity(nextActivity2);
            };
            btnContinueCreate.Click += (s, e) =>
            {
                Intent nextActivity3 = new Intent(this, typeof(GameLayout));
                StartActivity(nextActivity3);
            };
            btnContinueChoose.Click += (s, e) =>
            {
                Intent nextActivity4 = new Intent(this, typeof(GameLayout));
                StartActivity(nextActivity4);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}