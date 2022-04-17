using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;
using System;

namespace TravelCLient.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allReviews = Review.GetReviews();
            Console.WriteLine("All Reviews" + allReviews);
            return View(allReviews);
        }
    }
}