using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API1
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
    : base(options)
        {

        }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fabricante>(entity =>
            { 
            entity.ToTable("Fabricante");
                entity.HasKey(e => e.Codigo);
            entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.ToTable("Articulo");

                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);
                entity.Property(e => e.Precio)
                .IsRequired()
                .IsUnicode(false);

                entity.HasOne(d => d.fabricante)
                .WithMany(e => e.Articulos)
                .HasForeignKey(d => d.Fabricante_id)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
