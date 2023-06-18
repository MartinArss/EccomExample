namespace Domain.Entities
{
    public class Estado
    {
        [Key] public int IdEstado { get; set; }

        public string NomEst { get; set; } = null!;

        public string Codigo { get; set; } = null!;

        [ForeignKey("IdPaisNavigation")] public int IdPais { get; set; }
        public Pais IdPaisNavigation { get; set; } = null!;
    }
}
