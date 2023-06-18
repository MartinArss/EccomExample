namespace Domain.Entities
{
    public class Cliente
    {
        [Key] public int IdCliente { get; set; }

        public string NombreCli { get; set; } = null!;

        public string ApellidosCli { get; set; } = null!;

        public string TelefonoCli { get; set; } = null!;

        public int FechaNacCli { get; set; }

        public string Correo { get; set; } = null!;

        public string NomUsuario { get; set; } = null!;

        public string PasswordCli { get; set; } = null!;

        public int FechaRegistro { get; set; }

        [ForeignKey("IdDireccionNavigation")] public int IdDireccion { get; set; }

        [ForeignKey("IdEstadoCuentaNavigation")] public int IdEstadoCuenta { get; set; }

        [ForeignKey("IdGeneroNavigation")] public int IdGenero { get; set; }

        public Direccion IdDireccionNavigation { get; set; } = null!;

        public EstadoCuenta IdEstadoCuentaNavigation { get; set; } = null!;

        public Genero IdGeneroNavigation { get; set; } = null!;
    }
}
