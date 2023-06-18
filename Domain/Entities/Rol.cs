namespace Domain.Entities
{
    public class Rol
    {
        [Key] public int IdRol { get; set; }

        public string NomRol { get; set; } = null!;
    }
}
