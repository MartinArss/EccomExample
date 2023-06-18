namespace Domain.Entities
{
    public class Direccion
    {
        [Key] public int IdDireccion { get; set; }

        public string CodigoPostal { get; set; } = null!;

        public string Calle1 { get; set; } = null!;

        public string? Calle2 { get; set; }

        public string Numero { get; set; } = null!;

        public string? InfoExtra { get; set; }

        [ForeignKey("IdCiudadNavigation")] public int IdCiudad { get; set; }

        public Ciudad IdCiudadNavigation { get; set; } = null!;
    }
}
