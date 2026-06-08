using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using urbancompany_salon.Models;

namespace urbancompany_salon.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any services.
            if (context.SalonServices.Any())
            {
                return;   // DB has been seeded
            }

            var services = new SalonService[]
            {
                new SalonService { Name = "Haircut", Description = "Professional haircut service", Price = 25.00M },
                new SalonService { Name = "Manicure", Description = "Nail care and polish", Price = 15.00M },
                new SalonService { Name = "Facial", Description = "Relaxing facial treatment", Price = 40.00M },
                new SalonService { Name = "Massage", Description = "Full body massage", Price = 60.00M }
            };

            foreach (SalonService s in services)
            {
                context.SalonServices.Add(s);
            }
            context.SaveChanges();
        }
    }
}