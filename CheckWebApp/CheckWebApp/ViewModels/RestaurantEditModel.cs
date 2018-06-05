using CheckWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheckWebApp.ViewModels
{
    public class RestaurantEditModel
    {

        [Display(Name = "Restaurant Name")]
        [Required, StringLength(30)]
        public String Name { get; set; }

        [Display(Name = "Cuisine Type")]
        public Cuisine Cuisine { get; set; }
    }
}
