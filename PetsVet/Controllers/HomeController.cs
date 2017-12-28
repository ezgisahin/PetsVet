using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetsVet.Models;

namespace PetsVet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Kliniğiniz Hakkında";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "İletişim Sayfamız";

            return View();
        }

        public IActionResult Appointment()
        {
            ViewData["Message"] = "Randevu Alınız";

            return View();
        }

        public IActionResult Doctors()
        {
            ViewData["Message"] = "Doktorlarımız";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
