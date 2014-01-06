using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WODpile.Models;

namespace WODpile.Controllers
{
    public class MovementsController : Controller
    {
        public ActionResult Movements()
        {
            Movements movements = new Movements(2);
            
            return View(movements);
        }

    }
}
