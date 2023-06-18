namespace Domain.Entities
{
    public class MetodoPago
    {
        [Key] public int IdMetodoPago { get; set; }

        public string NomMetPag { get; set; } = null!;

        public byte[] Icono { get; set; } = null!;

        public int FechaCreacion { get; set; }
    }
}
