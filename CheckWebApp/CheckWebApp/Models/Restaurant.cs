using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheckWebApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Display(Name="Restaurant Name De La pincia")]
        public String Name { get; set; }
        [Display(Name = "Cuisine Type De La pincia")]
        public Cuisine Cuisine { get; set; }
    }
}
