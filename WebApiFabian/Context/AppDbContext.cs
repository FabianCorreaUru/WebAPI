using Microsoft.EntityFrameworkCore;
using WebApiFabian.Modelos;

namespace WebApiFabian.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
                
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }


    }
}
