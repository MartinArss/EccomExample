namespace Domain.Entities
{
    public class CarritoCompra
    {
        [Key] public int IdCarritoCompra { get; set; }

        public double Subtotal { get; set; }

        public double Impuestos { get; set; }

        public int Descuento { get; set; }

        public double Total { get; set; }

        public int FechaCreacion { get; set; }

        public int FechaActualizacion { get; set; }

        public string? Observaciones { get; set; }

        [ForeignKey("IdEstadoCarritoNavigation")] public int IdEstadoCarrito { get; set; }

        [ForeignKey("IdClienteNavigation")] public int IdCliente { get; set; }

        [ForeignKey("IdPagoNavigation")] public int IdPago { get; set; }

        public Cliente IdClienteNavigation { get; set; } = null!;

        public EstadoCarrito IdEstadoCarritoNavigation { get; set; } = null!;

        public Pago IdPagoNavigation { get; set; } = null!;
    }
}
