using DIDemoinAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Data
{
    public class DataDbContext : DbContext
    {
        //db ile bağlantı kuracak olan class
        public DataDbContext(DbContextOptions<DataDbContext>options):base(options) //startuptan yönetmek için yazdık
        {
            //ef her veritabanıyla çalışır
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Price).IsRequired();

        }

    }
}
