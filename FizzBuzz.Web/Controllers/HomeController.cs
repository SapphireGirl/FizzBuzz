using FizzBuzz.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FizzBuzz.Web.ViewModels;
using FizzBuzz.Web.Builders;
using FizzBuzz.Web.Repositories;


namespace FizzBuzz.Web.Controllers
{
    // REST APIs should use attribute routing
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserViewModel _vm;
        

        public HomeController(ILogger<HomeController> logger, IUserViewModel vm)
        {
            _vm = vm;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        [Route("Home")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                return View(_vm);
            }

            // #Requirement: Return a view with a collection of objects
            // I like to use View Models so in this case my ViewModel has a collection of Users

            // Seed collection on ViewModel
            _vm.PopulateUsersOnViewModel();
            return View(_vm);
        }

        [HttpPost]
        [Route("/Users/Add")]
        public IActionResult AddUser()
        {
            if (!ModelState.IsValid)
            {
                return View(_vm);
            }

            // #Requirement: Return a view with a collection of objects
            // I like to use View Models so in this case my ViewModel has a collection of Users

            return View(_vm);
        }

        // These templates are just left in from project creation
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}