
using Microsoft.EntityFrameworkCore;

namespace HafizeNalbant_CodelabProjesi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-58K1FK9; database=CoreCodelabProje; integrated security=true;");
        }

        public DbSet<Kişiler> kisiler { get; set; }
    }
}
