namespace Domain.Entities
{
    public class ModeloNegocio
    {
        [Key] public int IdModeloNegocio { get; set; }

        public string NomMod { get; set; } = null!;

        public string Descripcion { get; set; } = null!;
    }
}
