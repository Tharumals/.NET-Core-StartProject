using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HList.Data
{
    public class Hotel
    {
        public int HotelID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }


        [ForeignKey(nameof(Country))]
        public int CountryID { get; set; }

        public Country Country { get; set; }

        
    }
}
