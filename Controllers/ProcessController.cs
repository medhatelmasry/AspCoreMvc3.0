using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspcoreMvc.Controllers
{
    public class ProcessController : Controller
    {
        public IActionResult Index()
        {
            Process[] p = Process.GetProcesses();
            ViewBag.myProcesses = p;
            return View();
        }

        public IActionResult Welcome()
        {
            Process[] p = Process.GetProcesses();
            //ViewBag.myProcesses = p;
            return View(p);
        }

        public IActionResult Display(int id)
        {
            Process p = Process.GetProcessById(id);
            return View(p);
        }
    }
}