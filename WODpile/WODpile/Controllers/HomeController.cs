using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WODpile.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            
            //The view returned here will be the name of this action method - Index.cshtml
            return View();
        }

        //public String Index() {
        //    return "Hey there...";
        //}

    }

}
