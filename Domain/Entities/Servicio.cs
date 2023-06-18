namespace Domain.Entities
{
    public class Servicio
    {
        [Key] public int IdServicio { get; set; }

        public string NomServi { get; set; } = null!;

        public string DescripcionSer { get; set; } = null!;
    }
}
