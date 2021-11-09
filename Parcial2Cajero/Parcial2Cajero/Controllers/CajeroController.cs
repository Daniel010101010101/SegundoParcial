using Parcial2Cajero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2Cajero.Controllers
{
    public class CajeroController : Controller
    {
        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index1(ClsCajero c)
        {
            _ = c;

            if (c.cantidad % 5 == 0)
            {
                return Redirect("Resultado");
            }
            else
            {
                return Redirect("Error");
            }

        }
        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Resultado()
        {
            return View();
        }
    }
}
        

