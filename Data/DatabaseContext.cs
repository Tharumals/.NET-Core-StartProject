using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HList.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions option) : base(option)
        {
        }

    
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
               new Country
               {
                   CountryID = 1,
                   Name = "Sri Lanka",
                   ShortName = "SL"
               },
               new Country
               {
                   CountryID = 2,
                   Name = "Australia",
                   ShortName = "AU"
               },

                new Country
                {
                    CountryID = 3,
                    Name = "New Zreland",
                    ShortName = "NZ"
                }
                );

            builder.Entity<Hotel>().HasData(
              new Hotel
              {
                  HotelID = 1,
                  Name = "Hilton ",
                  Address = "Colombo",
                  CountryID = 1,
                  Rating = 5.0
              },
              new Hotel
              {
                  HotelID = 2,
                  Name = "New Moon",
                  Address = "Perth",
                  CountryID = 2,
                  Rating = 4.0
              },

              new Hotel
              {
                  HotelID = 3,
                  Name = "River Face",
                  Address = "Welington",
                  CountryID = 3,
                  Rating = 4.5
              }
               );
        }

    }
}
