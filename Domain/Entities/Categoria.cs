namespace Domain.Entities
{
    public class Categoria
    {
        [Key] public int IdCategoria { get; set; }

        public string NomCat { get; set; } = null!;
    }
}
