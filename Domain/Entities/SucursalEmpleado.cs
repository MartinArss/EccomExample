namespace Domain.Entities
{
    public class SucursalEmpleado
    {
        [ForeignKey("IdSucursalNavigation")]
        public int IdSucursal { get; set; }
        public Sucursal? IdSucursalNavigation { get; set; }

        [ForeignKey("IdEmpleadoNavigation")]
        public int IdEmpleado { get; set; }
        public Empleado? IdEmpleadoNavigation { get; set; }
    }
}
