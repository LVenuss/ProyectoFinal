namespace DataEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelTiendaTecno : DbContext
    {
        public ModelTiendaTecno()
            : base("name=ModelTiendaTecno")
        {
        }

        public virtual DbSet<Bodega> Bodega { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaCheque> FacturaCheque { get; set; }
        public virtual DbSet<FacturaContado> FacturaContado { get; set; }
        public virtual DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual DbSet<Pagina> Pagina { get; set; }
        public virtual DbSet<PaginaRol> PaginaRol { get; set; }
        public virtual DbSet<PaginaUsuario> PaginaUsuario { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoPedido> ProductoPedido { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bodega>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.Bodega)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.formaPago)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .HasOptional(e => e.FacturaCheque)
                .WithRequired(e => e.Factura);

            modelBuilder.Entity<Factura>()
                .HasOptional(e => e.FacturaContado)
                .WithRequired(e => e.Factura);

            modelBuilder.Entity<Factura>()
                .HasMany(e => e.FacturaDetalle)
                .WithRequired(e => e.Factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacturaCheque>()
                .Property(e => e.nombreBanco)
                .IsUnicode(false);

            modelBuilder.Entity<Pagina>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Pagina>()
                .HasMany(e => e.PaginaRol)
                .WithRequired(e => e.Pagina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pagina>()
                .HasMany(e => e.PaginaUsuario)
                .WithRequired(e => e.Pagina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaginaRol>()
                .Property(e => e.ver)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaRol>()
                .Property(e => e.modificar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaRol>()
                .Property(e => e.insertar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaRol>()
                .Property(e => e.eliminar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaUsuario>()
                .Property(e => e.ver)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaUsuario>()
                .Property(e => e.modificar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaUsuario>()
                .Property(e => e.insertar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaginaUsuario>()
                .Property(e => e.eliminar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pedido>()
                .HasMany(e => e.ProductoPedido)
                .WithRequired(e => e.Pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.excento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.FacturaDetalle)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ProductoPedido)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.Telefono)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.PaginaRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuario)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.PaginaUsuario)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Pedido)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
