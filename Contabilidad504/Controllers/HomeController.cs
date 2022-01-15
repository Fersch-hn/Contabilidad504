using Contabilidad504.Models;
using Contabilidad504.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Contabilidad504.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWorkBookService _workBookService;

        public HomeController(ILogger<HomeController> logger, IWorkBookService workBookService)
        {
            _logger = logger;
            _workBookService = workBookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //_workBookService.InsertTextInWorksheet(@"C:\Users\Fernando Martinez\Desktop\ejemplo.xlsx", "Adios", "B", 2, "Hoja1");
            var hello =_workBookService.GetCellValue(@"C:\Users\Fernando Martinez\Desktop\ejemplo.xlsx",  "Hoja1", "B2");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
