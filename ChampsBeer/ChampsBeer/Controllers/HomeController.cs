using ChampsBeer.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static ChampsBeer.Models.AllBeers;

namespace ChampsBeer.Controllers
{
    public class HomeController : Controller
    {
        API_Response rsp = new API_Response();
        public async Task<ActionResult> Index()
        {
           
            ViewBag.all = await rsp.Search();
            
            return View();
        }


        public async Task<ActionResult> All()
        {

            ViewBag.all = await rsp.ALL();


            return View();
        }

        [HttpGet]
        public async Task<ActionResult> ById( string Id)
        {

            ViewBag.all = await rsp.ById(Id);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}