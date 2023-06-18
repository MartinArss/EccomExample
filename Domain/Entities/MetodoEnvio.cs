namespace Domain.Entities
{
    public class MetodoEnvio
    {
        [Key] public int IdMetodoEnvio { get; set; }

        public string NomMetEnv { get; set; } = null!;
    }
}
