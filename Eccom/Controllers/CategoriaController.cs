namespace Eccom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        // Inyeccion de dependencias (Interfaz de categoria)
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        // Endpoints
        [HttpGet("ListaCategorias")]
        public async Task<ActionResult<Response<List<ObtenerCategoriaDto>>>> ListaCategorias()
        {
            return Ok(await _categoriaService.VerCategorias());
        }

        [HttpGet("UnaCategoria/{id}")]
        public async Task<ActionResult<Response<ObtenerCategoriaDto>>> UnaCategoria(int id)
        {
            return Ok(await _categoriaService.VerUnaCategoria(id));
        }

        [HttpGet("CategoriasPorNombre/{nombre}")]
        public async Task<ActionResult<Response<List<ObtenerCategoriaDto>>>> VerCategoriasPorNombre(string nombre)
        {
            return Ok(await _categoriaService.VerCategoriaNombre(nombre));
        }

        [HttpPost("AgregarCategoria")]
        public async Task<ActionResult<Response<List<ObtenerCategoriaDto>>>> AgregarCategoria(CrearCategoriaDto categoria)
        {
            return Ok(await _categoriaService.CrearCategoria(categoria));
        }

        [HttpPut("ModificarCategoria/{id}")]
        public async Task<ActionResult<Response<List<ObtenerCategoriaDto>>>> ModificarCategoria(ActualizarCategoriaDto actualizarCategoria, int id)
        {
            var response = await _categoriaService.ActualizarCategoria(actualizarCategoria, id);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }

        [HttpDelete("RemoverCategoria/{id}")]
        public async Task<ActionResult<Response<ObtenerCategoriaDto>>> RemoverPersonaje(int id)
        {
            var response = await _categoriaService.EliminarCategoria(id);
            if (response.Data is null)
                return NotFound(response);
            return Ok(response);
        }
    }
}
