using System;
using System.Collections.Generic;
using System.Text;
using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AccomodationType> AccomodationTypes { get; set; }
        public DbSet<AccomodationPackage> AccomodationPackages { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
