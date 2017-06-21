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
using SQLite;

namespace Make_A_Drink
{
    [Activity(Label = "DrinkList")]
    public class DrinkList : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DrinkListView);
            // ui interface
            //ListView dummyList = FindViewById<ListView>(Resource.Id.DummyListLayout);

            // db vars
            var docsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = System.IO.Path.Combine(docsFolder, "drinks.db");

            var drinks = LookUpAll(path);
            this.ListAdapter = new ArrayAdapter<Drink>(this, Android.Resource.Layout.SimpleListItem1, drinks);
        }


        //protected override void OnListItemClick(ListView l, View v, int position, long id)

        private List<Drink> LookUpAll(string path)
        {
            var conn = new SQLiteConnection(path);
            var drink_list = conn.Query<Drink>("SELECT * FROM Drinks");
            return drink_list;
        }

        //private List<Drink> LookUpName(string name, string path)
        //{
        //    var conn = new SQLiteConnection(path);
        //    List<Drink> drink_list;

        //    if (name != null && name != "")
        //    {
        //        var query = "SELECT * FROM Dummy WHERE Name = '" + name + "'";
        //        drink_list = conn.Query<Drink>(query);
        //    }
        //    else
        //    {
        //        var query = "SELECT * FROM Dummy";
        //        drink_list = conn.Query<Drink>(query);
        //    }
        //    return drink_list;
        //}
    }
}