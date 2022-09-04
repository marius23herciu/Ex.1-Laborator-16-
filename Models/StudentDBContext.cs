using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex._1_Laborator_16_.Models
{
    class StudentDBContext : DbContext
    {
        public DbSet<Student> Students {get;set;}
        public StudentDBContext():base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\seb\Desktop\fasttrackIT\Projects\Laborator 16\Ex.1(Laborator 16)\StudentsManagement.mdf; Integrated Security = True");
        }
    }
}
