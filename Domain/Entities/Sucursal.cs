namespace Domain.Entities
{
    public class Sucursal
    {
        [Key] public int IdSucursal { get; set; }

        public string RfcSuc { get; set; } = null!;

        public string NomSuc { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public int FechaApertura { get; set; }

        public int FechaCierre { get; set; }

        public byte[] Imagen { get; set; } = null!;

        public string PoliticasPrivacidad { get; set; } = null!;

        public string TerminosCondiciones { get; set; } = null!;

        public string InfoExtra { get; set; } = null!;

        [ForeignKey("IdDireccionNavigation")] public int IdDireccion { get; set; }

        [ForeignKey("IdCadenaNavigation")] public int IdCadena { get; set; }

        [ForeignKey("IdServicioNavigation")] public int IdServicio { get; set; }

        [ForeignKey("IdEstadoSucursalNavigation")]public int IdEstadoSucursal { get; set; }

        public Cadena IdCadenaNavigation { get; set; } = null!;

        public Direccion IdDireccionNavigation { get; set; } = null!;

        public EstadoSucursal IdEstadoSucursalNavigation { get; set; } = null!;

        public Servicio IdServicioNavigation { get; set; } = null!;
    }
}
