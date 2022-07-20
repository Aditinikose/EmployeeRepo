using Employee1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace Employee1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Employee1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Employee1Context>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Name = "mno pqr",
                        DateOfBirth = DateTime.Parse("1989-2-12"),
                        Email = "mnopqr@gmail.com",
                        Salary = 73444
                       
                    },

                    new Employee
                    {
                        Name = "def ghi",
                        DateOfBirth = DateTime.Parse("1984-3-13"),
                        Email = "defghi@gmail.com",
                        Salary = 20993
                      
                    },

                    new Employee
                    {
                        Name = "pqr lmn",
                        DateOfBirth = DateTime.Parse("1986-2-23"),
                        Email = "pqrlmn@gmail.com",
                        Salary =34889
                       
                    },

                    new Employee
                    {
                        Name = "abc xyz",
                        DateOfBirth = DateTime.Parse("1959-4-15"),
                       Email = "abcxyz@gmail.com",
                      Salary= 35767
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

