using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoApi.Data;
using System.Linq;
using ToDoApi.Models;

namespace ToDoApi.Models
{
    public static class PrepDbToDoTable
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ToDoApiContext>());
            }
        }

        public static void SeedData(ToDoApiContext context)
        {
            System.Console.WriteLine("Applying Migrations...");

            context.Database.Migrate();

            if(!context.ToDos.Any())
            {
                System.Console.WriteLine("Adding Data - seeding");
                context.ToDos.AddRange(
                    new ToDo{Id=0, Name="Buy Eggs", IsDone=false},
                    new ToDo{Id=0, Name="Read Book", IsDone=true},
                    new ToDo{Id=0, Name="Listen to 1 new song", IsDone=true},
                    new ToDo{Id=0, Name="Meditate", IsDone=false}
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data - not seeding");
            }
        }

    }
}