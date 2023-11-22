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

namespace DataAccess.Concrete.EntityFrameWrok.Context
{
    public class NorthwindContext:DbContext// veritabanı ile haberleşmeyi saglayan nesne

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //tionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings[@"Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"].ConnectionString);
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Northwind; trusted_connection = true");
        }
       
        public DbSet<Product> Products { get; set; }//Mapping


    }
}
