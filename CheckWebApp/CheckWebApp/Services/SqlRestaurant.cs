using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckWebApp.Data;
using CheckWebApp.Models;

namespace CheckWebApp.Services
{
    public class SqlRestaurant : IRestaurantData
    {

       CheckWebAppDbContext dbContext;

        public SqlRestaurant(CheckWebAppDbContext _dbContext)
        {
            dbContext = _dbContext;
            
        }

        public Restaurant get(int id)
        {
            return dbContext.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> getAll()
        {
            return dbContext.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Add(Restaurant _restaurant)
        {
            dbContext.Restaurants.Add(_restaurant);
            dbContext.SaveChanges();
            return _restaurant;
        }

    }
}
