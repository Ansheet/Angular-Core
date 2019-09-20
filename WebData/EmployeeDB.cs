using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebData
{
    public class EmployeeDB : DbContext
    {
        public EmployeeDB(DbContextOptions<EmployeeDB> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
