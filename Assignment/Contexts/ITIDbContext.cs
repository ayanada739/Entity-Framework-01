using Assignment.Conventions;
using Assignment.Data_Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment.Fluent_API;

namespace Assignment.Contexts
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          =>  
            optionsBuilder.UseSqlServer("Server = .; Database = Enterprise; Trusted_Connection = true");

         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             

            // Relationship between Student , Stud_Course
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.Stud_Courses)
                .HasForeignKey(sc => sc.stud_ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(c => c.Stud_Courses)
                .HasForeignKey(sc => sc.Course_ID);

            // Relationship between  Course ,Course_Inst
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            modelBuilder.Entity<Course_Inst>()
            .HasOne<Instructor>(ci => ci.Instructor)
            .WithMany(i => i.Course_Insts)
            .HasForeignKey(ci => ci.inst_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne<Course>(ci => ci.Course)
                .WithMany(c => c.Course_Insts)
                .HasForeignKey(ci => ci.Course_ID);

            // Relationship between  Department , Instructor
            modelBuilder.Entity<Department>()
                .HasOne<Instructor>(d => d.Instructor)
                .WithOne(i => i.Department)
                .HasForeignKey<Department>(d => d.Ins_ID);

             


            modelBuilder.Entity<Topic>()
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    





    }
}
