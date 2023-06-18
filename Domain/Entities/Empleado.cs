namespace Domain.Entities
{
    public class Empleado
    {
        [Key] public int IdEmpleado { get; set; }

        public string RfcEmp { get; set; } = null!;

        public string NombreEmp { get; set; } = null!;

        public string ApellidosEmp { get; set; } = null!;

        public int FechaNacEmp { get; set; }

        public string Telefono { get; set; } = null!;

        public string NombreUsuario { get; set; } = null!;

        public string EmailEmp { get; set; } = null!;

        public string PasswordEmp { get; set; } = null!;

        [ForeignKey("IdRolNavigation")] public int IdRol { get; set; }

        [ForeignKey("IdDireccionNavigation")] public int IdDireccion { get; set; }

        public Direccion IdDireccionNavigation { get; set; } = null!;

        public Rol IdRolNavigation { get; set; } = null!;
    }
}
