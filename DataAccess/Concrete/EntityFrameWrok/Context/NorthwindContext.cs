using Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;

namespace DataAccess.Concrete.EntityFrameWrok.Context
{
    public class NorthwindContext:DbContext// veritabanı ile haberleşmeyi saglayan nesne

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Northwind; trusted_connection = true");
        }
       
        public DbSet<Product> Products { get; set; }//Mapping
        public DbSet<Category> Categories { get; set; }//Mapping
        public DbSet<User> Users { get; set; }//Mapping
        public DbSet<OperationClaim> operationClaims { get; set; }//Mapping
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }//Mapping


    }
}
