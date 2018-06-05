using CheckWebApp.Models;
using CheckWebApp.Services;
using CheckWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckWebApp.Controllers
{
    public class HomeController : Controller
    {

        IRestaurantData restaurantDataSource;
        IGreeting greeting;

        public HomeController(IRestaurantData rd, IGreeting gr)
        {
            restaurantDataSource = rd;
            greeting = gr;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = restaurantDataSource.getAll();
            model.CurrentMessage = greeting.getGreting();
            return View(model);
        }
        public IActionResult Restaurant()
        {
            var model = restaurantDataSource.getAll();
            return new ObjectResult(model);
        }

        public IActionResult Details(int id)
        {
            var model = restaurantDataSource.get(id);
            return View(model);
        }
        public IActionResult RestaurantView()
        {
            var model = restaurantDataSource.getAll();
            return View("Restaurant",model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditModel _restaurant)
        {
            if (ModelState.IsValid)
            {
                Restaurant newRestaurant = new Restaurant();
                newRestaurant.Name = _restaurant.Name;
                newRestaurant.Cuisine = _restaurant.Cuisine;
                newRestaurant = restaurantDataSource.Add(newRestaurant);
                return RedirectToAction("Details", new { id = newRestaurant.Id });
            }
            else return View();
        }
    }
}
