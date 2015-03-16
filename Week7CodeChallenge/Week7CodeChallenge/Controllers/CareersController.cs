using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class CareersController : Controller
    {
        /// GET: Careers 
         [HttpGet] 
         public ActionResult Index() 
         { 
             if (Request.IsAjaxRequest()) 
             { 
                 return PartialView(); 
             } 
             return View(); 
         } 

    }
}