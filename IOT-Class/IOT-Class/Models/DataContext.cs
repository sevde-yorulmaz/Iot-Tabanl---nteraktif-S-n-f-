using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class DataContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public DataContext(DbContextOptions<DataContext> options) :
          base(options)
        {

        }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;Integrated Security=True;database=IOTClassDb;");

            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
    }
}
