using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleRegistrationPage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static SimpleRegistratorPageLibrary.BussinesLogic.AccountProssesor;
using SimpleRegistratorPageLibrary.Model;

namespace SimpleRegistrationPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult List()
        {
            var accounts = ListAccount();
            return View(accounts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SimpleRegistrationPage.Models.Account acc)
        {
            SimpleRegistratorPageLibrary.Model.Account tempacc = new SimpleRegistratorPageLibrary.Model.Account()
            {
                username = acc.username,
                password = acc.password,
                email = acc.email,
                address = acc.address,
                phone = acc.phone,
                gender = acc.gender
            };
            CreateAccount(tempacc);
            return RedirectToAction("List");
        }
    }
}
