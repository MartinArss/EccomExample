namespace Domain.Entities
{
    public class Envio
    {
        public string? ReferenciaEnvio { get; set; }

        [ForeignKey("IdDireccionNavigation")] public int IdDireccion { get; set; }

        [ForeignKey("IdMetodoEnvioNavigation")] public int IdMetodoEnvio { get; set; }

        [ForeignKey("IdVentasNavigation")] public int IdVentas { get; set; }

        [ForeignKey("IdEstadoEnvioNavigation")] public int IdEstadoEnvio { get; set; }

        public EstadoEnvio IdEstadoEnvioNavigation { get; set; } = null!;

        public Direccion IdDireccionNavigation { get; set; } = null!;

        public MetodoEnvio IdMetodoEnvioNavigation { get; set; } = null!;

        public Venta IdVentasNavigation { get; set; } = null!;
    }
}
