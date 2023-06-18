namespace Domain.Entities
{
    public class EstadoPago
    {
        [Key] public int IdEstadoPago { get; set; }

        public string NomEstPag { get; set; } = null!;
    }
}
