namespace Domain.Entities
{
    public class Producto
    {
        [Key] public int IdProducto { get; set; }

        public string CodigoBarras { get; set; } = null!;

        public string NumeroSerie { get; set; } = null!;

        public string NomPro { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public double Precio { get; set; }

        public double Impuestos { get; set; }

        public int Descuento { get; set; }

        public byte[] ImagenProd { get; set; } = null!;

        public int Stock { get; set; }

        public int FechaCreacion { get; set; }

        public int FechaActualizacion { get; set; }

        [ForeignKey("IdCategoriaNavigation")] public int IdCategoria { get; set; }

        [ForeignKey("IdMarcaNavigation")] public int IdMarca { get; set; }

        [ForeignKey("IdCarritoCompraNavigation")] public int IdCarritoCompra { get; set; }

        public CarritoCompra IdCarritoCompraNavigation { get; set; } = null!;

        public Categoria IdCategoriaNavigation { get; set; } = null!;

        public Marca IdMarcaNavigation { get; set; } = null!;
    }
}
