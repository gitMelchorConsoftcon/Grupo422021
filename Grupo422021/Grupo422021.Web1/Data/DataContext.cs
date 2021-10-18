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

        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<OrdenServicio> OrdenServicio { get; set; }
        public DbSet<OrdenServicioDetalle> OrdenServicioDetalle { get; set; }


    }
}
