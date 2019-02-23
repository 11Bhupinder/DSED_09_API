using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DSED_07_Web_Development.Models;
using System.Net;

namespace DSED_07_Web_Development.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult SearchApi()
        {
            ViewData["Message"] = "Your your Search  Page page.";

            return View();
        }


        public ActionResult Search(string query)
        {

            string apiKey = "AIzaSyBv-EM_Dq27eAAXSQLERCIBzJb_3I-CwE4";
            string cx = "014866169754120585633:hgy0gg0o7g8";
            //query = "Augmrny";
            var svc = new Google.Apis.Customsearch.v1.CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = svc.Cse.List(query);
            listRequest.Cx = cx;
            var search = listRequest.Execute();
            var results = search.Items;
            ViewBag.results = results;
            return View();

           


        }



       

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
