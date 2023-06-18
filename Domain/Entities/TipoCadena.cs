namespace Domain.Entities
{
    public class TipoCadena
    {
        [Key] public int IdTipoCadena { get; set; }

        public string NomTipCad { get; set; } = null!;

        public string DescripcionCad { get; set; } = null!;

        [ForeignKey("IdModeloNegocioNavigation")] public int IdModeloNegocio { get; set; }

        public ModeloNegocio IdModeloNegocioNavigation { get; set; } = null!;
    }
}
