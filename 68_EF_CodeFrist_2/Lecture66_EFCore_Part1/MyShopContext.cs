using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lecture66_EFCore_Part1
{
    class MyShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"])
                .UseLoggerFactory(LoggerFactory.Create(builder=> builder.AddConsole()));
           // options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MYShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
           
        
    }
}

