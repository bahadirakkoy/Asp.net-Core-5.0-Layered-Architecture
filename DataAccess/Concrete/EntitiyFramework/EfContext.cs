
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string mySqlConnectionStr = Configuration.GetConnectionString("DefaultConnection");
            string MySqlConnectionStr = "server=localhost;database=TestDb;uid=root;password=;";
            optionsBuilder.UseMySql(MySqlConnectionStr, ServerVersion.AutoDetect(MySqlConnectionStr));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
