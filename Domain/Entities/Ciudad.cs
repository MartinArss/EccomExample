namespace Domain.Entities
{
    public class Ciudad
    {
        [Key] public int IdCiudad { get; set; }

        public string NomCiu { get; set; } = null!;

        [ForeignKey("IdEstadoNavigation")] public int IdEstado { get; set; }

        public Estado IdEstadoNavigation { get; set; } = null!;
    }
}
