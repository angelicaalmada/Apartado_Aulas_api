using Apartado_Aulas_api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Apartado_Aulas_api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Edificio> Edificios { get; set; }
    }
}
