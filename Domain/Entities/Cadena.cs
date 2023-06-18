namespace Domain.Entities
{
    public class Cadena
    {
        [Key] public int IdCadena { get; set; }

        public string RfcCad { get; set; } = null!;

        public string NomCad { get; set; } = null!;

        public byte[]? Imagen { get; set; }

        public string? PoliticasPrivacidad { get; set; }

        public string? TerminosCondiciones { get; set; }

        [ForeignKey("IdDireccionNavegation")]
        public int IdDireccion { get; set; }
        public Direccion? IdDireccionNavigation { get; set; }

        [ForeignKey("IdTipoCadenaNavigation")]
        public int IdTipoCadena { get; set; }

        public TipoCadena? IdTipoCadenaNavigation { get; set; }
    }
}