using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;
using SQLite;
using System.Net;

namespace Make_A_Drink
{
    [Activity(Label = "Make_A_Drink", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            //Interface
            Button lookUpButton = FindViewById<Button>(Resource.Id.LookUpButton);

            // create DB path
            var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var pathToDatabase = System.IO.Path.Combine(docsFolder, "drinks.db");

            // create db if needed
            if (!File.Exists(pathToDatabase))
            {
                createDB(pathToDatabase);
                var reason = "Dummy Database Created~";
                Toast.MakeText(Application.Context, reason, ToastLength.Long).Show();
            }

            //Main Layout Button events
            //addButton.Click += (sender, e) =>
            //{
            //    StartActivity(typeof(AddDummy));
            //};

            lookUpButton.Click += (sender, e) =>
            {
                StartActivity(typeof(DrinkList));
            };

        }

        private string createDB(string path)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://cmhedrick.me/db/drinks.db", path);

                return "Database created";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }
    }
}

