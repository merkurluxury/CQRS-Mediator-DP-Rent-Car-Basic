using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarWithPatterns.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-34LNO3L\\MSSQLSERVER01; initial Catalog=CarWithPatterns; TrustServerCertificate=True; integrated security=true");
        }

        public DbSet<Car> Cars { get; set; }
        
    }
}
