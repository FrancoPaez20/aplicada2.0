namespace AplicadaFinal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AplicadaBD : DbContext
    {
        public AplicadaBD()
            : base("name=AplicadaBD")
        {
        }

        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<marca> marca { get; set; }
        public virtual DbSet<modelo> modelo { get; set; }
        public virtual DbSet<orden> orden { get; set; }
        public virtual DbSet<ordenempleado> ordenempleado { get; set; }
        public virtual DbSet<ordenestado> ordenestado { get; set; }
        public virtual DbSet<ordenservicio> ordenservicio { get; set; }
        public virtual DbSet<servicio> servicio { get; set; }
        public virtual DbSet<serviciostock> serviciostock { get; set; }
        public virtual DbSet<stock> stock { get; set; }
        public virtual DbSet<tipo> tipo { get; set; }
        public virtual DbSet<vehiculo> vehiculo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cliente>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.vehiculo)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.id_cliente);

            modelBuilder.Entity<empleado>()
                .Property(e => e.nombreyapellido)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<marca>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<marca>()
                .HasMany(e => e.modelo)
                .WithRequired(e => e.marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<modelo>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<modelo>()
                .HasMany(e => e.servicio)
                .WithRequired(e => e.modelo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<modelo>()
                .HasMany(e => e.vehiculo)
                .WithRequired(e => e.modelo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orden>()
                .HasMany(e => e.ordenestado)
                .WithRequired(e => e.orden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orden>()
                .HasMany(e => e.ordenservicio)
                .WithRequired(e => e.orden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servicio>()
                .Property(e => e.detalle)
                .IsUnicode(false);

            modelBuilder.Entity<servicio>()
                .Property(e => e.precio)
                .IsUnicode(false);

            modelBuilder.Entity<servicio>()
                .HasMany(e => e.ordenservicio)
                .WithRequired(e => e.servicio)
                .HasForeignKey(e => e.id_servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servicio>()
                .HasMany(e => e.serviciostock)
                .WithRequired(e => e.servicio)
                .HasForeignKey(e => e.id_servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<stock>()
                .Property(e => e.detalle)
                .IsUnicode(false);

            modelBuilder.Entity<stock>()
                .Property(e => e.precio)
                .IsUnicode(false);

            modelBuilder.Entity<stock>()
                .Property(e => e.minimo)
                .IsUnicode(false);

            modelBuilder.Entity<stock>()
                .Property(e => e.cantidad)
                .IsUnicode(false);

            modelBuilder.Entity<stock>()
                .HasMany(e => e.serviciostock)
                .WithRequired(e => e.stock)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo>()
                .Property(e => e.detalle)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculo>()
                .Property(e => e.patente)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculo>()
                .Property(e => e.annio)
                .IsUnicode(false);
        }
    }
}
