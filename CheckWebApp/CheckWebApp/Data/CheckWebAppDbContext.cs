using CheckWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckWebApp.Data
{
    public class CheckWebAppDbContext:DbContext
    {
        public CheckWebAppDbContext()
        {
           public DbSet<Restaurant> Restaurants { get; set; }
                
        }
    }
}
