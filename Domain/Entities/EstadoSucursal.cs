namespace Domain.Entities
{
    public class EstadoSucursal
    {
        [Key] public int IdEstadoSucursal { get; set; }

        public string? NomEstSuc { get; set; }
    }
}
