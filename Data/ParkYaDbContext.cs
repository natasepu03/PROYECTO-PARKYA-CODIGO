using Microsoft.EntityFrameworkCore;
using ParkYa.Models;

namespace ParkYa.Data
{
    public class ParkYaDbContext : DbContext
    {
        public ParkYaDbContext(DbContextOptions<ParkYaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<Vehiculo> vehiculo { get; set; }
        public DbSet<TipoVehiculo> tipo_vehiculo { get; set; }
        public DbSet<Parqueadero> parqueadero { get; set; }
        public DbSet<Reserva> reserva { get; set; }
        public DbSet<Tarifa> tarifas { get; set; }
        public DbSet<Venta> venta { get; set; }
        public DbSet<DetalleVenta> detalleventa { get; set; }
    }
}