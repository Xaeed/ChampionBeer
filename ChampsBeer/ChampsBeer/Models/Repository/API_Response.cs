﻿using System;
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

#region  to show data from search  parameter 
        public async Task<List<Datum>> Search()
        {
            try
            { 
            string key= System.Configuration.ConfigurationManager.AppSettings["Key"];
          var  all = await BreweryDbFactory<IBeer>.GetData("9c7ec492dc1a9248f78b2672fe67fed9" ,new KeyValuePair<string, string>("ibu", "4")/*,new KeyValuePair<string,string>("Abv","4"), new KeyValuePair<string, string>("StyleId", "2")*/);
            
            List<Datum> lstDatm = new List<Datum>();
          
            foreach (var item in all.Take(2))
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
                    a.description = item.Available.Description;
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
                dt.abv = item.Abv;
                dt.servingTemperatureDisplay = item.ServingTemperatureDisplay;
                dt.beerVariationId = item.BeerVariationId;
                dt.statusDisplay = item.StatusDisplay;
                dt.foodPairings = item.FoodPairings;
                dt.servingTemperature = item.ServingTemperature;
                dt.abv = item.Abv;
                dt.year = item.Year;
                dt.id = item.Id;
                dt.name = item.Name;
                dt.originalGravity = item.OriginalGravity;
                dt.ibu = item.Ibu;
                dt.isOrganic = item.IsOrganic.ToString();
                dt.description = item.Description;
                
             
                 lstDatm.Add(dt);
            }

            if (lstDatm !=null)
            {
                return await Task.FromResult(lstDatm.ToList());
            }
            }
            catch(Exception ex)
            {
                return null;
            }
            return null;
        }

        #endregion

#region show data by beer id 
        public async Task<List<Datum>> ById( string Id  )
        {
            if (Id != null)
            {
                try { 
                string id = Id;
                string key = System.Configuration.ConfigurationManager.AppSettings["Key"];
                var all = await BreweryDbFactory<IBeer>.GetData("9c7ec492dc1a9248f78b2672fe67fed9", new KeyValuePair<string, string>("ids", id));

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
                    dt.name = item.Name;

                    lstDatm.Add(dt);
                }

                if (lstDatm != null)
                {

                    return await Task.FromResult(lstDatm.ToList());
                }
                }
                catch(Exception ex)
                {
                    return null;

                }
            }
            else
            {

                return   null;
            }

            return null;

        }
        #endregion
#region  to show all data 
        public async Task<List<Datum>> ALL()
        {
            try
            { 
            string key = System.Configuration.ConfigurationManager.AppSettings["Key"];
            var all = await BreweryDbFactory<IBeer>.GetData("9c7ec492dc1a9248f78b2672fe67fed9", new KeyValuePair<string, string>("ibu", "4"));

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
            }
            catch(Exception ex)
            { 
            return null;
            }
            return null;
        }
#endregion
    }
}