using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//adding this namespace allows access to any model classes declared in the Models folder. 
using WODpile.Models;

namespace WODpile.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Details()
        {
            User CurrentUser = new User()
            {
                ID = 12,
                UserName = "Joe Schmoe"
            };
            
            return View();
        }

    }
}
