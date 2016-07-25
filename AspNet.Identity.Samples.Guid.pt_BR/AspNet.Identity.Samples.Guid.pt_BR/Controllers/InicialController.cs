﻿using System.Web.Mvc;

namespace AspNet.Identity.Samples.Common.Controllers
{
    public class InicialController : Controller
    {
        public ActionResult Indice()
        {
            return View();
        }

        [Authorize]
        public ActionResult Sobre()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
