using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eccom.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCarritos",
                columns: table => new
                {
                    IdEstadoCarrito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEstCar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCarritos", x => x.IdEstadoCarrito);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCuentas",
                columns: table => new
                {
                    IdEstadoCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCuentas", x => x.IdEstadoCuenta);
                });

            migrationBuilder.CreateTable(
                name: "EstadoEnvios",
                columns: table => new
                {
                    IdEstadoEnvio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEstEnv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoEnvios", x => x.IdEstadoEnvio);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPagos",
                columns: table => new
                {
                    IdEstadoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEstPag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPagos", x => x.IdEstadoPago);
                });

            migrationBuilder.CreateTable(
                name: "EstadoSucursales",
                columns: table => new
                {
                    IdEstadoSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEstSuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoSucursales", x => x.IdEstadoSucursal);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomGen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomMar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "MetodoEnvios",
                columns: table => new
                {
                    IdMetodoEnvio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomMetEnv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoEnvios", x => x.IdMetodoEnvio);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPagos",
                columns: table => new
                {
                    IdMetodoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomMetPag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icono = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FechaCreacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagos", x => x.IdMetodoPago);
                });

            migrationBuilder.CreateTable(
                name: "ModeloNegocios",
                columns: table => new
                {
                    IdModeloNegocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomMod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloNegocios", x => x.IdModeloNegocio);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomPais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomRol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IdServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomServi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionSer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.IdServicio);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTitular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaExpiracion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<int>(type: "int", nullable: false),
                    IdMetodoPago = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pagos_MetodoPagos_IdMetodoPago",
                        column: x => x.IdMetodoPago,
                        principalTable: "MetodoPagos",
                        principalColumn: "IdMetodoPago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoCadenas",
                columns: table => new
                {
                    IdTipoCadena = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomTipCad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionCad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdModeloNegocio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCadenas", x => x.IdTipoCadena);
                    table.ForeignKey(
                        name: "FK_TipoCadenas_ModeloNegocios_IdModeloNegocio",
                        column: x => x.IdModeloNegocio,
                        principalTable: "ModeloNegocios",
                        principalColumn: "IdModeloNegocio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                    table.ForeignKey(
                        name: "FK_Estados_Paises_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Paises",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCiu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCiudad);
                    table.ForeignKey(
                        name: "FK_Ciudades_Estados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoExtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.IdDireccion);
                    table.ForeignKey(
                        name: "FK_Direcciones_Ciudades_IdCiudad",
                        column: x => x.IdCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cadenas",
                columns: table => new
                {
                    IdCadena = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RfcCad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomCad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PoliticasPrivacidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminosCondiciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDireccion = table.Column<int>(type: "int", nullable: false),
                    IdDireccionNavigationIdDireccion = table.Column<int>(type: "int", nullable: true),
                    IdTipoCadena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadenas", x => x.IdCadena);
                    table.ForeignKey(
                        name: "FK_Cadenas_Direcciones_IdDireccionNavigationIdDireccion",
                        column: x => x.IdDireccionNavigationIdDireccion,
                        principalTable: "Direcciones",
                        principalColumn: "IdDireccion");
                    table.ForeignKey(
                        name: "FK_Cadenas_TipoCadenas_IdTipoCadena",
                        column: x => x.IdTipoCadena,
                        principalTable: "TipoCadenas",
                        principalColumn: "IdTipoCadena",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidosCli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoCli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacCli = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordCli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<int>(type: "int", nullable: false),
                    IdDireccion = table.Column<int>(type: "int", nullable: false),
                    IdEstadoCuenta = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Direcciones_IdDireccion",
                        column: x => x.IdDireccion,
                        principalTable: "Direcciones",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_EstadoCuentas_IdEstadoCuenta",
                        column: x => x.IdEstadoCuenta,
                        principalTable: "EstadoCuentas",
                        principalColumn: "IdEstadoCuenta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Generos_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "Generos",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RfcEmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidosEmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacEmp = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailEmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordEmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdDireccion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Direcciones_IdDireccion",
                        column: x => x.IdDireccion,
                        principalTable: "Direcciones",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "Roles",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    IdSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RfcSuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomSuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaApertura = table.Column<int>(type: "int", nullable: false),
                    FechaCierre = table.Column<int>(type: "int", nullable: false),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PoliticasPrivacidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerminosCondiciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoExtra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDireccion = table.Column<int>(type: "int", nullable: false),
                    IdCadena = table.Column<int>(type: "int", nullable: false),
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    IdEstadoSucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IdSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursales_Cadenas_IdCadena",
                        column: x => x.IdCadena,
                        principalTable: "Cadenas",
                        principalColumn: "IdCadena",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sucursales_Direcciones_IdDireccion",
                        column: x => x.IdDireccion,
                        principalTable: "Direcciones",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sucursales_EstadoSucursales_IdEstadoSucursal",
                        column: x => x.IdEstadoSucursal,
                        principalTable: "EstadoSucursales",
                        principalColumn: "IdEstadoSucursal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sucursales_Servicios_IdServicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicios",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarritoCompras",
                columns: table => new
                {
                    IdCarritoCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subtotal = table.Column<double>(type: "float", nullable: false),
                    Impuestos = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    FechaCreacion = table.Column<int>(type: "int", nullable: false),
                    FechaActualizacion = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEstadoCarrito = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdPago = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarritoCompras", x => x.IdCarritoCompra);
                    table.ForeignKey(
                        name: "FK_CarritoCompras_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarritoCompras_EstadoCarritos_IdEstadoCarrito",
                        column: x => x.IdEstadoCarrito,
                        principalTable: "EstadoCarritos",
                        principalColumn: "IdEstadoCarrito",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarritoCompras_Pagos_IdPago",
                        column: x => x.IdPago,
                        principalTable: "Pagos",
                        principalColumn: "IdPago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SucursalEmpleados",
                columns: table => new
                {
                    IdSucursal = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucursalEmpleados", x => new { x.IdSucursal, x.IdEmpleado });
                    table.ForeignKey(
                        name: "FK_SucursalEmpleados_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado");
                    table.ForeignKey(
                        name: "FK_SucursalEmpleados_Sucursales_IdSucursal",
                        column: x => x.IdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal");
                });

            migrationBuilder.CreateTable(
                name: "HistorialCompras",
                columns: table => new
                {
                    FechaCompra = table.Column<int>(type: "int", nullable: false),
                    TotalCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCarritoCompra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_HistorialCompras_CarritoCompras_IdCarritoCompra",
                        column: x => x.IdCarritoCompra,
                        principalTable: "CarritoCompras",
                        principalColumn: "IdCarritoCompra",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoBarras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomPro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Impuestos = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false),
                    ImagenProd = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<int>(type: "int", nullable: false),
                    FechaActualizacion = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    IdCarritoCompra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_CarritoCompras_IdCarritoCompra",
                        column: x => x.IdCarritoCompra,
                        principalTable: "CarritoCompras",
                        principalColumn: "IdCarritoCompra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRealizada = table.Column<int>(type: "int", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEntrega = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdEstadoPago = table.Column<int>(type: "int", nullable: false),
                    IdCarritoCompra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_CarritoCompras_IdCarritoCompra",
                        column: x => x.IdCarritoCompra,
                        principalTable: "CarritoCompras",
                        principalColumn: "IdCarritoCompra");
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado");
                    table.ForeignKey(
                        name: "FK_Ventas_EstadoPagos_IdEstadoPago",
                        column: x => x.IdEstadoPago,
                        principalTable: "EstadoPagos",
                        principalColumn: "IdEstadoPago");
                });

            migrationBuilder.CreateTable(
                name: "Subproductos",
                columns: table => new
                {
                    NomSubProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagenSubProd = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Subproductos_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Envios",
                columns: table => new
                {
                    ReferenciaEnvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDireccion = table.Column<int>(type: "int", nullable: false),
                    IdMetodoEnvio = table.Column<int>(type: "int", nullable: false),
                    IdVentas = table.Column<int>(type: "int", nullable: false),
                    IdEstadoEnvio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Envios_Direcciones_IdDireccion",
                        column: x => x.IdDireccion,
                        principalTable: "Direcciones",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Envios_EstadoEnvios_IdEstadoEnvio",
                        column: x => x.IdEstadoEnvio,
                        principalTable: "EstadoEnvios",
                        principalColumn: "IdEstadoEnvio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Envios_MetodoEnvios_IdMetodoEnvio",
                        column: x => x.IdMetodoEnvio,
                        principalTable: "MetodoEnvios",
                        principalColumn: "IdMetodoEnvio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Envios_Ventas_IdVentas",
                        column: x => x.IdVentas,
                        principalTable: "Ventas",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cadenas_IdDireccionNavigationIdDireccion",
                table: "Cadenas",
                column: "IdDireccionNavigationIdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Cadenas_IdTipoCadena",
                table: "Cadenas",
                column: "IdTipoCadena");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoCompras_IdCliente",
                table: "CarritoCompras",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoCompras_IdEstadoCarrito",
                table: "CarritoCompras",
                column: "IdEstadoCarrito");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoCompras_IdPago",
                table: "CarritoCompras",
                column: "IdPago");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_IdEstado",
                table: "Ciudades",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdDireccion",
                table: "Clientes",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdEstadoCuenta",
                table: "Clientes",
                column: "IdEstadoCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdGenero",
                table: "Clientes",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_IdCiudad",
                table: "Direcciones",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdDireccion",
                table: "Empleados",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdRol",
                table: "Empleados",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdDireccion",
                table: "Envios",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdEstadoEnvio",
                table: "Envios",
                column: "IdEstadoEnvio");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdMetodoEnvio",
                table: "Envios",
                column: "IdMetodoEnvio");

            migrationBuilder.CreateIndex(
                name: "IX_Envios_IdVentas",
                table: "Envios",
                column: "IdVentas");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_IdPais",
                table: "Estados",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCompras_IdCarritoCompra",
                table: "HistorialCompras",
                column: "IdCarritoCompra");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdMetodoPago",
                table: "Pagos",
                column: "IdMetodoPago");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCarritoCompra",
                table: "Productos",
                column: "IdCarritoCompra");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdMarca",
                table: "Productos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Subproductos_IdProducto",
                table: "Subproductos",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_SucursalEmpleados_IdEmpleado",
                table: "SucursalEmpleados",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdCadena",
                table: "Sucursales",
                column: "IdCadena");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdDireccion",
                table: "Sucursales",
                column: "IdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdEstadoSucursal",
                table: "Sucursales",
                column: "IdEstadoSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdServicio",
                table: "Sucursales",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCadenas_IdModeloNegocio",
                table: "TipoCadenas",
                column: "IdModeloNegocio");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IdCarritoCompra",
                table: "Ventas",
                column: "IdCarritoCompra");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IdEmpleado",
                table: "Ventas",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IdEstadoPago",
                table: "Ventas",
                column: "IdEstadoPago");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Envios");

            migrationBuilder.DropTable(
                name: "HistorialCompras");

            migrationBuilder.DropTable(
                name: "Subproductos");

            migrationBuilder.DropTable(
                name: "SucursalEmpleados");

            migrationBuilder.DropTable(
                name: "EstadoEnvios");

            migrationBuilder.DropTable(
                name: "MetodoEnvios");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "EstadoPagos");

            migrationBuilder.DropTable(
                name: "CarritoCompras");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Cadenas");

            migrationBuilder.DropTable(
                name: "EstadoSucursales");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "EstadoCarritos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "TipoCadenas");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "EstadoCuentas");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "MetodoPagos");

            migrationBuilder.DropTable(
                name: "ModeloNegocios");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
