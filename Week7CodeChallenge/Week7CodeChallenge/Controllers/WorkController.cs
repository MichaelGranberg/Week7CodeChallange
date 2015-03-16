using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class WorkController : Controller
    {
          // GET: Work 
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