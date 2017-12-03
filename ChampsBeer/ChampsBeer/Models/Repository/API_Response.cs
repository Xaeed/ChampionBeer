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



            }

            if (lstDatm != null)
            {

                return await Task.FromResult(lstDatm.ToList());
            }


            return null;


        }
    }
}