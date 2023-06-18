namespace Domain.Entities
{
    public class EstadoCuenta
    {
        [Key] public int IdEstadoCuenta { get; set; }

        public string Descripcion { get; set; } = null!;
    }
}
