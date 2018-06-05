using CheckWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckWebApp.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> getAll();
        Restaurant get(int id);
        Restaurant Add(Restaurant newRestaurant);
    }
}
