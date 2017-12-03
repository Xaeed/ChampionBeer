using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChampsBeer.Models
{
    public class AllBeers
    {
        public class Labels
        {
            public string Medium { get; set; }
            public string Large { get; set; }
            public string Icon { get; set; }
        }

        public class Category
        {
            public string updateDate { get; set; }
            public int id { get; set; }
            public string description { get; set; }
            public string createDate { get; set; }
            public string name { get; set; }
        }

        public class Style
        {
            public int id { get; set; }
            public Category category { get; set; }
            public string description { get; set; }
            public string ibuMax { get; set; }
            public string srmMin { get; set; }
            public string srmMax { get; set; }
            public string ibuMin { get; set; }
            public string ogMax { get; set; }
            public string fgMin { get; set; }
            public string fgMax { get; set; }
            public string createDate { get; set; }
            public string updateDate { get; set; }
            public string abvMax { get; set; }
            public string ogMin { get; set; }
            public string abvMin { get; set; }
            public string name { get; set; }
            public int categoryId { get; set; }
        }

        public class Available
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class Glass
        {
            public string updateDate { get; set; }
            public int id { get; set; }
            public string description { get; set; }
            public string createDate { get; set; }
            public string name { get; set; }
        }

        public class Datum
        {

            
            public Datum()
            {
                style = new Style();
                Labels = new Labels();
                available = new Available();
                glass = new Glass();
            }
           


            public string LMedium { get; set; }
            public string LLarge { get; set; }
            public string Icon { get; set; }
            public string servingTemperatureDisplay { get; set; }
            public Style style { get; set; }
            public string status { get; set; }
            public string srmId { get; set; }
            public Labels Labels { get; set; }
            public string beerVariationId { get; set; }
            public string statusDisplay { get; set; }
            public string foodPairings { get; set; }
            public List<object> srm { get; set; }
            public string updateDate { get; set; }
            public string servingTemperature { get; set; }
            public int availableId { get; set; }
            public List<object> beerVariation { get; set; }
            public string abv { get; set; }
            public string year { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public string originalGravity { get; set; }
            public int styleId { get; set; }
            public string ibu { get; set; }
            public int glasswareId { get; set; }
            public string isOrganic { get; set; }
            public string createDate { get; set; }
            public Available available { get; set; }
            public Glass glass { get; set; }
            public string description { get; set; }
        }

        public class RootObject
        {
            public string status { get; set; }
            public int numberOfPages { get; set; }
            public List<Datum> data { get; set; }
            public int currentPage { get; set; }
        }
    }
}