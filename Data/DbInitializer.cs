using EONRealityFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EONRealityFinal.Data
{
    public class DbInitializer
    {
        public static void Initialize(EONRealityFinalContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{Name="Carson",Email="carson@asd.com",Gender="Male",DateRegistered=DateTime.Now,EventDays="Day 1,Day 2",Request="No Request from Carson"},
                new User{Name="Maggie",Email="maggie@asd.com",Gender="Female",DateRegistered=DateTime.Now,EventDays="Day 2",Request="No Request from Maggie"},
                new User{Name="Jennifer",Email="dada@asd.com",Gender="Male",DateRegistered=DateTime.Now,EventDays="Day 1,Day 2,Day 3",Request="No Request from Jennifer"}
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
