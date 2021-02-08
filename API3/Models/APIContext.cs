using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API3
{
    public class APIContext:DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
: base(options)
        {

        }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Caja> Cajas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.ToTable("Almacen");
                entity.HasKey(e => e.Codigo);
                entity.Property(e => e.Lugar)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);
                entity.Property(e => e.Capacidad)
                .IsRequired()
                .IsUnicode(false);
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.ToTable("Caja");

                entity.HasKey(e => e.NumReferencia);

                entity.Property(e => e.Contenido)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                entity.Property(e => e.Valor)
                        .IsRequired()
                        .IsUnicode(false);

                entity.HasOne(d => d.almacen)
                        .WithMany(e => e.Cajas)
                        .HasForeignKey(d => d.CodigoAlmacen)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
