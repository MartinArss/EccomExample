namespace Domain.Entities
{
    public class Venta
    {
        [Key] public int IdVenta { get; set; }

        public int FechaRealizada { get; set; }

        public string? Comentarios { get; set; }

        public int FechaEntrega { get; set; }

        [ForeignKey("IdEmpleadoNavigation")] public int IdEmpleado { get; set; }

        public Empleado? IdEmpleadoNavigation { get; set; }

        [ForeignKey("IdEstadoPagoNavigation")] public int IdEstadoPago { get; set; }

        public EstadoPago? IdEstadoPagoNavigation { get; set; }

        [ForeignKey("IdCarritoCompraNavigation")] public int IdCarritoCompra { get; set; }

        public CarritoCompra? IdCarritoCompraNavigation { get; set; }
    }
}
