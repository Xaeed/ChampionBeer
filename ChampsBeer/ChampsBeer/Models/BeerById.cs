using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampsBeer.Models
{
    public class BeerById
    {
        public class Glass
        {
            public int id { get; set; }
            public string createDate { get; set; }
            public string name { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string createDate { get; set; }
            public string name { get; set; }
        }

        public class Style
        {

            public int id { get; set; }
            public Category category { get; set; }
            public string srmMax { get; set; }
            public string ibuMax { get; set; }
            public string srmMin { get; set; }
            public string description { get; set; }
            public string fgMin { get; set; }
            public string ibuMin { get; set; }
            public string createDate { get; set; }
            public string fgMax { get; set; }
            public string abvMax { get; set; }
            public string ogMin { get; set; }
            public string abvMin { get; set; }
            public string name { get; set; }
            public int categoryId { get; set; }
        }

        public class Labels
        {
            public string medium { get; set; }
            public string large { get; set; }
            public string icon { get; set; }
        }


        public class Data
        {
            public string id { get; set; }
            public string abv { get; set; }
            public string name { get; set; }
            public Glass glass { get; set; }
            public Style style { get; set; }
            public string createDate { get; set; }
            public Labels labels { get; set; }
            public int styleId { get; set; }
            public string updateDate { get; set; }
            public int glasswareId { get; set; }
            public string isOrganic { get; set; }
            public string status { get; set; }
            public string statusDisplay { get; set; }
        }

        public class RootObject
        {
            public string status { get; set; }
            public Data data { get; set; }
            public string message { get; set; }
        }
    }
}