﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChampsBeer;
using ChampsBeer.Controllers;
using System.Threading.Tasks;

namespace ChampsBeer.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {



        ChampsBeer.Models.Repository.API_Response response = new Models.Repository.API_Response();
        [TestMethod]
        public void Index()
        {
 #region main index simple test
            HomeController controller = new HomeController();

            var result =   controller.Index() as Task<ActionResult>;
            Assert.IsNotNull(result);
#endregion
            
        }
        
        [TestMethod]
        public void ById()
        {

#region simple id test 
            string a="J21liv";
            HomeController controller = new HomeController();
            var result =  controller.ById(a) as Task<ActionResult>;
            Assert.IsNotNull(result);
            #endregion

#region error test
            string dummy = "1231312";
            var IdResponse = response.ById(dummy);
            Assert.IsNull(IdResponse);
#endregion

        }


        [TestMethod]
        public void All()
        {
#region simple test 
            HomeController controller = new HomeController();
            var result = controller.All() as Task<ActionResult>;
            Assert.IsNotNull(result);
 #endregion

#region we can make complex and robust tests for repository or businesss logics 
            ChampsBeer.Models.Repository.API_Response api = new Models.Repository.API_Response();

            var all = api.ALL();
            Assert.IsNotNull(all);
#endregion
        }


        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
