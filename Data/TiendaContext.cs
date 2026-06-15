using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVinos.Models;

namespace TiendaVinos.Data
{
    public class TiendaContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetallesCompra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Se conecta a la base de datos de prueba (LocalDB) de Visual Studio
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TiendaVinosDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Le decimos que el precio usa dos decimales
            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasColumnType("decimal(18,2)");
        }
    }
}
