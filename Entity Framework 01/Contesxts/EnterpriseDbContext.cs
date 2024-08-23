using Entity_Framework_01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_01.Contesxts
{
    //Dbcontext : Container Of Database
    //            Deal With Database Through it 
    //            Application Can Have More Than One Dbcontext

    // You Need To Inherit Build Class "DbContext" To Inherit Function "OnCongig" To Configure Ur Data
    // Data [Database Name , Server Name, Type Of Auth]
    // Built In Class "DbContext" Exists In Library (Microsoft.EntityFrameworkCore)
    //Library (Microsoft.EntityFrameworkCore) Exists In Package (Microsoft.EntityFrameworkCore. SqlServer)
    internal class EnterpriseDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          =>   //optionsBuilder.UseSqlServer("Data source = . ; Initial Catalog = Enterprise; Integarted Security = true") //old
            optionsBuilder.UseSqlServer("Server = .; Database = Enterprise; Trusted_Connection = true");
        

        public DbSet<Employee> employees { get; set; }
        //Map Class To Table => Property InSide Class Dbcontext Must be Dbset Of Entity
        // Name Of Table = Name Of Property

        public DbSet<Department> departments { get; set; }
        public DbSet<Projects>  projects { get; set; }
     }
}
