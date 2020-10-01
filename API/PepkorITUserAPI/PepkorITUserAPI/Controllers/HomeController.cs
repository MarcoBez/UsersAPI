using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PepkorITUserAPI.Controllers
{
    /// <summary>  
    /// PepkorIT User API - Create, Retrieve, Update Delete
    /// Author: Marco Bezuidenhout September 2020
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>  
        /// PepkorIT User API - Home Page
        /// </summary>
        public ActionResult Index()
        {
            ViewBag.Title = "PepkorIT User API";

            return View();
        }
    }
}
