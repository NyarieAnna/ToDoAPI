using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using TodoList.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TodoList.Data
{
     public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Tasks.Any())
                {
                    context.Tasks.AddRange(new Task()
                    {
                        taskName = "Laundry",
                        Status = "Completed",
                        date = DateTime.Now.AddDays(-3),
                        Deleted = true
                    },
                    new Task()
                    {
                        taskName = "Coding",
                        Status = "InProgress",
                        date = DateTime.Now,
                        Deleted = false
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}


