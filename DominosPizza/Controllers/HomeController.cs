﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DominosPizza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rules()
        {
            return View();
        }

        public ActionResult HowToOrder()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Vacations()
        {
            return View();
        }
    }
}