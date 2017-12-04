using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ZenOfBeer.BreweryDb.Pcl.Public;
using static ChampsBeer.Models.AllBeers;

namespace ChampsBeer.Models.Repository
{
    public class API_Response
    {
        public async Task<List<Datum>> ShowAll()
        {
            string key= System.Configuration.ConfigurationManager.AppSettings["Key"];
            var all = await BreweryDbFactory<IBeer>.GetData("9c7ec492dc1a9248f78b2672fe67fed9", new KeyValuePair<string, string>("ibu", "10"));
            
            List<Datum> lstDatm = new List<Datum>();
          
            foreach (var item in all)
            {
                Datum dt = new Datum();

                if (item.Labels != null)
                {
                    dt.Labels = new Labels();
                    Labels l = new Labels();
                    l.Large = item.Labels.Large;
                    l.Medium = item.Labels.Medium;
                    l.Icon = item.Labels.Icon;

                    dt.Labels = l;
                }

                if (item.Available != null)
                {
                    Available a = new Available();
                    dt.available = new Available();
                    a.name = item.Available.Name;
                    dt.available = a;
                }

                dt.style.ibuMin = item.Style.IbuMin;
                dt.style.ibuMax = item.Style.IbuMax;
                dt.style.abvMin = item.Style.AbvMin;
                dt.style.abvMax = item.Style.AbvMax;
                dt.style.srmMin = item.Style.SrmMin;
                dt.style.srmMax = item.Style.SrmMax;
                dt.style.ogMin = item.Style.OgMin;
                dt.style.ogMax = item.Style.OgMax;
                dt.style.fgMin = item.Style.FgMin;
                dt.style.fgMax = item.Style.FgMax;
                dt.servingTemperatureDisplay = item.ServingTemperatureDisplay;
                dt.beerVariationId = item.BeerVariationId;
                dt.statusDisplay = item.StatusDisplay;
                dt.foodPairings = item.FoodPairings;
                dt.servingTemperature = item.ServingTemperature;
                dt.abv = item.Abv;
                dt.year = item.Year;
                dt.id = item.Id;
                dt.originalGravity = item.OriginalGravity;
                dt.ibu = item.Ibu;
                dt.isOrganic = item.IsOrganic.ToString();
                dt.description = item.Description;
             
                 lstDatm.Add(dt);
            }

            if (lstDatm != null)
            {

                return await Task.FromResult(lstDatm.ToList());
            }


            return null;


        }
    }
}