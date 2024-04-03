using System;
using Microsoft.EntityFrameworkCore;

namespace Usuarios.Models
{
    public partial class DatosContext : DbContext
    {
        public DatosContext()
        {
        }

        public DatosContext(DbContextOptions<DatosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localDb)\\senati;Database=Datos;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado).HasName("PK__empleado__FC29D6F64922E65C");

                entity.ToTable("empleados");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("Idempleado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DNI)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCelular)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date");

                entity.Property(e => e.Domicilio)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
