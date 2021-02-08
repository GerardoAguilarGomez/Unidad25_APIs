using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using API2;

namespace API2
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
: base(options)
        {

        }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamento");
                entity.HasKey(e => e.Codigo);
                entity.Property(e => e.Nombre)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);
                entity.Property(e => e.Presupuesto)
                .IsRequired()
                .IsUnicode(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("Empleado");

                entity.HasKey(e => e.Dni);

                entity.Property(e => e.Nombre)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false);

                entity.HasOne(d => d.departamento)
                        .WithMany(e => e.Empleados)
                        .HasForeignKey(d => d.CodigoDepartamento)
                        .OnDelete(DeleteBehavior.ClientSetNull);

            });
        }
        }
}
