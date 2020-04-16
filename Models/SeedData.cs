using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication7.Models;
using System;
using System.Linq;
using WebApplication7.Data.Entities;

namespace WebApplication7.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EmployeeContext>>()))
            {
                // Look for any movies.
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employees.AddRange(
                    new Employee
                    {
                        Id = 1,
                        FullName="Luan",
                        Email="luan@gmail.com",
                        Phone="0123",
                        Address="quang trung",
                        DepartmentId=1
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}