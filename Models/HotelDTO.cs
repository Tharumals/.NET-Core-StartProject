using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HList.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength:150, ErrorMessage ="Hotel Name Is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Addres  Is too long")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryID { get; set; }
    }

    public class HotelDTO : CreateCountryDTO
    {
        public int HotelID { get; set; } 

        public CountryDTO Country { get; set; }
    }
}
