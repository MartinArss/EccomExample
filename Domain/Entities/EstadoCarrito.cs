namespace Domain.Entities
{
    public class EstadoCarrito
    {
        [Key] public int IdEstadoCarrito { get; set; }

        public string NomEstCar { get; set; } = null!;
    }
}
