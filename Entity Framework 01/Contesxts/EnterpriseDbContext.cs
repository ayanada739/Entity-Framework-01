using Entity_Framework_01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_01.Contesxts
{
    //Dbcontext : Container Of Database
    //            Deal With Database Through it 
    //            Application Can Have More Than One Dbcontext
    internal class EnterpriseDbContext : DbContext
    {
        public EnterpriseDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          =>   //optionsBuilder.UseSqlServer("Data source = . ; Initial Catalog = Enterprise; Integarted Security = true") //old
            optionsBuilder.UseSqlServer("Server = .; Database = Enterprise; Trusted_Connection = true");
        

        public DbSet<Employee> employees { get; set; }
           

    }
}
