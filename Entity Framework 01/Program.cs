using Entity_Framework_01.Contesxts;
using Entity_Framework_01.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region EF [Session 01]

            //EnterpriseDbContext dbContext = new EnterpriseDbContext();

            //dbContext.employees.Add();
            //dbContext.Database.EnsureDeleted();


            //Apply Migration To Database : EF => C# Code ==> SQL Statements

            //1. Code
            //dbContext.Database.Migrate(); // Apply Ups Of All Migrations [Not Applied]

            //2. Package Manager Console
            #endregion

            #region EF [Session 02]

            #region CRUD

            //try
            //{
            // CRUD=> Query Object Model
            //}
            //finally
            //{
            // Release || Free || Deallocate || Close || Dispose Unmanaged Resources
            // dbContext. Dispose(); // Close Db Connection
            //}
            /// / Syntax Suger => Try Finally
            //using(EnterpriseDbContext dbContext = new EnterpriseDbContext())
            //{

            //}
            // Syntax Suger
            using EnterpriseDbContext dbContext = new EnterpriseDbContext();

            // CRUD=> Query Object Model

            Employee Emp01 = new Employee()
            {

                //EmpId = 1 , //Invalid => Column has Identity

                Name = "Aya",
                Age = 32,
                Salary = 4_000,
                Email = "Aya@gmail.com",
                Password = "Password",
                PhoneNumber = "12345678"
            };

            Employee Emp02 = new Employee()
            {
                Name = "Ahmed",
                Age = 30,
                Salary = 3_000,
                Email = "Ahmed@gmail.com",
                Password = "Password123",
                PhoneNumber = "1234567890"
            };


            #region Insert
            //Console.WriteLine(dbContext.Entry(Emp01).State); //Detached
            //Console.WriteLine(dbContext.Entry(Emp02).State); //Detached

            /////dbContext.Set<Employee>().Add(Emp01);
            /////dbContext.Add(Emp01);
            /////dbContext.Entry(Emp01).State = EntityState.Added;

            //dbContext.employees.Add(Emp01); //Add Localy
            //dbContext.employees.Add(Emp02); //Add Localy

            //Console.WriteLine(dbContext.Entry(Emp01).State); //Added
            //Console.WriteLine(dbContext.Entry(Emp02).State); //Added

            ////Add In Database
            //dbContext.SaveChanges(); // Add Remote (BD)

            //Console.WriteLine(dbContext.Entry(Emp01).State); //Unchanged
            //Console.WriteLine(dbContext.Entry(Emp02).State); //Unchanged


            #endregion

            #region Retrive [Read]

            //var Employee = (from E in dbContext.employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(Employee?.Name ?? "Not Found");

            #endregion

            #region Update


            ////Emp01. Name = "Hamada";
            ////Console . WriteLine(dbContext. Entry(Empe01) . State); // Detached
            //var Employee = (from E in dbContext.employees
            //                where E.EmpId == 1
            //                select E) . FirstOrDefault();


            //Console.WriteLine(dbContext.Entry(Employee).State);
            //Employee.Name = "Hamada"; //Update Localy
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State);

            #endregion

            #region Delete- Remove

            //var Employee = (from E in dbContext.employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.employees.Remove(Employee); //Remove Localy
            //Console.WriteLine(dbContext.Entry(Employee).State);
            //dbContext.SaveChanges(); // Remove Remote (BD)
            //Console.WriteLine(dbContext.Entry(Employee).State);

            #endregion

            //Console.WriteLine("========================");
            //Console.WriteLine($"Emp 01 = {Emp01.EmpId}");
            //Console.WriteLine($"Emp 02 = {Emp02.EmpId}"); 


            #endregion


            #endregion
        }
    }
}
