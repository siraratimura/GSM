using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GSM.Controllers
{
    public class CheckOut : Controller
    {

        public IActionResult CO_Identify()
        {
            return View();
        }

        public IActionResult CO_Folio()
        {
            return View();
        }

        public IActionResult CO_NewPosting()
        {
            return View();
        }

        public IActionResult CO_Transfer()
        {
            return View();
        }

        public IActionResult CO_Payment()
        {
            return View();
        }
    }
}
