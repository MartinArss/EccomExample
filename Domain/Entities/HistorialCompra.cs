namespace Domain.Entities
{
    public class HistorialCompra
    {
        public int FechaCompra { get; set; }

        public string TotalCompra { get; set; } = null!;

        [ForeignKey("IdCarritoCompraNavigation")] public int IdCarritoCompra { get; set; }

        public CarritoCompra IdCarritoCompraNavigation { get; set; } = null!;
    }
}
