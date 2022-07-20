using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee1.Models;

namespace Employee1.Data
{
    public class Employee1Context : DbContext
    {
        public Employee1Context (DbContextOptions<Employee1Context> options)
            : base(options)
        {
        }

        public DbSet<Employee1.Models.Employee> Employee { get; set; } = default!;
    }
}
