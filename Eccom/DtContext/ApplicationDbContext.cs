namespace Eccom.DtContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // METODO SIN LLAVE PRIMARIA
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Envio>().HasNoKey();
            modelBuilder.Entity<HistorialCompra>().HasNoKey();
            modelBuilder.Entity<Subproducto>().HasNoKey();
            modelBuilder.Entity<SucursalEmpleado>().HasNoKey();

            // Eliminar ciclos en una tabla de unicamente dos claves foraneas en la tabla SucursalEmpleados
            modelBuilder.Entity<SucursalEmpleado>()
                .HasKey(se => new { se.IdSucursal, se.IdEmpleado });

            modelBuilder.Entity<SucursalEmpleado>()
                .HasOne(se => se.IdSucursalNavigation)
                .WithMany()
                .HasForeignKey(se => se.IdSucursal)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SucursalEmpleado>()
                .HasOne(se => se.IdEmpleadoNavigation)
                .WithMany()
                .HasForeignKey(se => se.IdEmpleado)
                .OnDelete(DeleteBehavior.NoAction);

            // El siguiente codigo realiza lo mismo que el de arriba pero para la tabla ventas
            modelBuilder.Entity<Venta>()
                .HasKey(v => v.IdVenta);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.IdEmpleadoNavigation)
                .WithMany()
                .HasForeignKey(v => v.IdEmpleado)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.IdEstadoPagoNavigation)
                .WithMany()
                .HasForeignKey(v => v.IdEstadoPago)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.IdCarritoCompraNavigation)
                .WithMany()
                .HasForeignKey(v => v.IdCarritoCompra)
                .OnDelete(DeleteBehavior.NoAction);
        }
        // MODELOS
        public DbSet<Cadena> Cadenas { get; set; }
        public DbSet<CarritoCompra> CarritoCompras { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Envio> Envios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<EstadoCarrito> EstadoCarritos { get; set; }
        public DbSet<EstadoCuenta> EstadoCuentas { get; set; }
        public DbSet<EstadoEnvio> EstadoEnvios { get; set; }
        public DbSet<EstadoPago> EstadoPagos { get; set; }
        public DbSet<EstadoSucursal> EstadoSucursales { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<HistorialCompra> HistorialCompras { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<MetodoEnvio> MetodoEnvios { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<ModeloNegocio> ModeloNegocios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Subproducto> Subproductos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<SucursalEmpleado> SucursalEmpleados { get; set; }
        public DbSet<TipoCadena> TipoCadenas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
