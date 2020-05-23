using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GC_StateManagementLab_ShoppingCart.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int RunTime { get; set; }
        public double RentalPrice { get; set; }

        public Movie()
        {
        }
        public Movie(string _title, string _description, int _runTime, double _rentalPrice)
        {
            Title = _title;
            Description = _description;
            RunTime = _runTime;
            RentalPrice = _rentalPrice;
        }
        public Movie(string _title, string _description, int _runTime)
        {
            Title = _title;
            Description = _description;
            RunTime = _runTime;
            RentalPrice = 6.99; //default price
        }

    }

}
