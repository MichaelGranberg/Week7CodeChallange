using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week7CodeChallenge.Models;

namespace Week7CodeChallenge.Controllers
{
    public class CompContactFormsController : Controller
    {
       // GET: Contact 
        [HttpGet] 
         public ActionResult Index() 
         { 
             if (Request.IsAjaxRequest()) 
             { 
                 return PartialView(); 
             } 
            return View(); 
        } 

       
 
         [HttpPost] 
         public ActionResult Index(Models.CompContactForm contactForm) 
         { 
             Models.sp6MichaelEntiesCompForm db = new Models.sp6MichaelEntiesCompForm(); 
             db.CompContactForms.Add(contactForm); 
             db.SaveChanges(); 
             return View("ThankYou"); 
        } 
     } 

}
