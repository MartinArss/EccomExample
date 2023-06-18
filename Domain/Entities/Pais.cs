namespace Domain.Entities
{
    public class Pais
    {
        [Key] public int IdPais { get; set; }

        public string NomPais { get; set; } = null!;

        public string Iso { get; set; } = null!;
    }
}
