namespace Domain.Entities
{
    public class EstadoEnvio
    {
        [Key] public int IdEstadoEnvio { get; set; }

        public string? NomEstEnv { get; set; }
    }
}
