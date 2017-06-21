using SQLite;
using System;

namespace Make_A_Drink
{
    class Drink
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string drink_name { get; set; }
        public string glass { get; set; }
        public string garnish { get; set; }
        public string measure_1 { get; set; }
        public string inredient_1 { get; set; }
        public string measure_2 { get; set; }
        public string inredient_2 { get; set; }
        public string measure_3 { get; set; }
        public string inredient_3 { get; set; }
        public string measure_4 { get; set; }
        public string inredient_4 { get; set; }
        public string measure_5 { get; set; }
        public string inredient_5 { get; set; }
        public string measure_6 { get; set; }
        public string inredient_6 { get; set; }
        public string measure_7 { get; set; }
        public string inredient_7 { get; set; }
        public string measure_8 { get; set; }
        public string inredient_8 { get; set; }
        public string measure_9 { get; set; }
        public string inredient_9 { get; set; }
        public string measure_10 { get; set; }
        public string inredient_10 { get; set; }
        public DateTime date_created { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}", drink_name);
        }
    }
}