namespace Domain.Entities
{
    public class Subproducto
    {
        public string NomSubProd { get; set; } = null!;

        public byte[] ImagenSubProd { get; set; } = null!;

        public string? Descripcion { get; set; }

        public double Precio { get; set; }

        [ForeignKey("IdProductoNavigation")] public int IdProducto { get; set; }

        public Producto IdProductoNavigation { get; set; } = null!;
    }
}
