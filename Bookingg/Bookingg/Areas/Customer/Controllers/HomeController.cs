using Booking.Models;
<<<<<<< HEAD
=======
using Booking.Models.ViewModels;
using Bookingg.DataAccess.Repository.Core;
>>>>>>> 860dc9c76a361a15f9467575dea54d013bf22dd4
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookingg.Areas.Customer.Controllers
{
    // We define areas in controller level
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
<<<<<<< HEAD

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
=======
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
>>>>>>> 860dc9c76a361a15f9467575dea54d013bf22dd4
        }

        public IActionResult Index()
        {
<<<<<<< HEAD
            return View();
=======
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType");
            return View(productList);
        }

        public IActionResult Details(int id)
        {
            ShoppingCart cartObj = new()
            {
                Count = 1,
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id, includeProperties: "Category,CoverType")
            };
            return View(cartObj);
>>>>>>> 860dc9c76a361a15f9467575dea54d013bf22dd4
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
    }
}