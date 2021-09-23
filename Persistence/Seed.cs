using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
//A static method is something that you can create inside the class. And When we use a static method,
//we don't need to create a new instance of this class will siply be able to sat seed and then SeedData without
//actually creating a new instance.	
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "cinema",
                    City = "Novi Sad",
                    Venue = "Cinaplex",
                },                      
                
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "culture",
                    City = "Athina",
                    Venue = "Akropoli",
                },

                new Activity
                {
                    Title = "Past Activity 3",
                    Date = DateTime.Now.AddMonths(-3),
                    Description = "Activity 3 months ago",
                    Category = "drinks",
                    City = "Novi Sad",
                    Venue = "IrishPub",
                },                      
                
                new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "music",
                    City = "Novi Sad",
                    Venue = "Exit festival",
                },

                new Activity
                {
                    Title = "Past Activity 5",
                    Date = DateTime.Now.AddMonths(-5),
                    Description = "Activity 5 months ago",
                    Category = "restourant",
                    City = "New York",
                    Venue = "Le Pain Quotidien",
                },                      
                
                new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "drinks",
                    City = "Novi Sad",
                    Venue = "Lazino tele",
                },

                new Activity
                {
                    Title = "Past Activity 7",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "travel",
                    City = "Bahams",
                    Venue = "Blue Lagoon Island Bahamas",
                },                      
                
                new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "The London Pub",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}
