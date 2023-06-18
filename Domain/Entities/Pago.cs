namespace Domain.Entities
{
    public class Pago
    {
        [Key] public int IdPago { get; set; }

        public string NombreTitular { get; set; } = null!;

        public string NumeroTarjeta { get; set; } = null!;

        public string Cvv { get; set; } = null!;

        public int FechaExpiracion { get; set; }

        public int FechaCreacion { get; set; }

        [ForeignKey("IdMetodoPagoNavigation")]public int IdMetodoPago { get; set; }

        public MetodoPago IdMetodoPagoNavigation { get; set; } = null!;
    }
}
