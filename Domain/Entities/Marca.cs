namespace Domain.Entities
{
    public class Marca
    {
        [Key] public int IdMarca { get; set; }

        public string NomMar { get; set; } = null!;
    }
}
