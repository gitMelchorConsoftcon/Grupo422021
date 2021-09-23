using Grupo422021.Web1.Models;
using Microsoft.EntityFrameworkCore;

namespace Grupo422021.Web1.Data
{
    public class DataContext:DbContext
    {
        public DataContext( DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
    }
}
