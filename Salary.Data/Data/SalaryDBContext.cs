using Microsoft.EntityFrameworkCore;
using Salary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salary.Data.Data
{
    public class SalaryDBContext : DbContext
    {

        public SalaryDBContext(DbContextOptions<SalaryDBContext> opt) : base(opt)
        {

        }

        public DbSet<Salary> Salaries { get; set; }

    }
}
