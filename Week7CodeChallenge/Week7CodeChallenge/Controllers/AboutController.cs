using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class AboutController : Controller 
     { 
         
           // GET: About/Index 
           [HttpGet] 
         public ActionResult Index() 
         { 
             if (Request.IsAjaxRequest()) 
             { 
                 return PartialView();
             } 
             return PartialView(); 
         } 


       
 
 
         // GET: About/Who 
         public ActionResult Who() 
         { 
             return PartialView(); 
         } 
         // GET: About/What 
         public ActionResult What() 
         { 
             return PartialView(); 
         } 
         // GET: About/Why 
         public ActionResult Why() 
         { 
             return PartialView(); 
         } 
         // GET: About/How 
         public ActionResult How() 
         { 
             return PartialView(); 
         } 
         // GET: About/Where 
         public ActionResult Where() 
         { 
             return PartialView(); 
         } 
     } 

}