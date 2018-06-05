using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckWebApp.Models;

namespace CheckWebApp.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurant()
        {
            restaurants = new List<Restaurant>
            {
                new Restaurant { Id=1, Name="Maria la zozza", Cuisine=Cuisine.French},
                new Restaurant { Id = 2, Name = "Cavour 21", Cuisine=Cuisine.Italian },
                new Restaurant { Id=3, Name="Il Polpo affogato", Cuisine=Cuisine.Greek}
            };
        }

        public Restaurant get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> getAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Add(Restaurant _restaurant)
        {
            _restaurant.Id = restaurants.Max(r => r.Id) + 1;
            restaurants.Add(_restaurant);
            return _restaurant;
        }

    }
}
