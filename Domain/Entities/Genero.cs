namespace Domain.Entities
{
    public class Genero
    {
        [Key] public int IdGenero { get; set; }

        public string NomGen { get; set; } = null!;
    }
}
