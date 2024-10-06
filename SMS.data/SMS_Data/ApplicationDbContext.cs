using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.data.SMS_Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ClassLevel> ClassLevels { get; set; }
        public DbSet<Attendence> Attendents { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<ResultSheet> ResultsSheets { get; set; }
        public DbSet<Exam> Exams { get; set; }

    }
}


