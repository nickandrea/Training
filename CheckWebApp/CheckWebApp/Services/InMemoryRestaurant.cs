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
                new Restaurant { Id=1, Name="Maria la zozza"},
                new Restaurant { Id = 2, Name = "Cavour 21" },
                new Restaurant { Id=3, Name="Il Polpo affogato"}
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

    }
}
