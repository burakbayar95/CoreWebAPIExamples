using Camping.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Data
{
    public class DataDbContext : DbContext
    {

        //db ile bağlantı kuracak olan class
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //startuptan yönetmek için yazdık
        {
            //ef her veritabanıyla çalışır
        }


        public DbSet<Camp> Camps { get; set; }

       
    }
}
