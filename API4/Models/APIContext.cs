using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API4
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
: base(options)
        {

        }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.ToTable("Pelicula");
                entity.HasKey(e => e.Codigo);
                entity.Property(e => e.Nombre)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);
                entity.Property(e => e.CalificacionEdad)
                .IsRequired()
                .IsUnicode(false);
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.ToTable("Sala");

                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Nombre)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);
                
                entity.HasOne(d => d.pelicula)
                        .WithMany(e =>e.Salas)
                        .HasForeignKey(d => d.CodigoPelicula)
                        .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
