namespace Eccom.Services.CategoriaService
{
    public interface ICategoriaService
    {
        Task<Response<List<ObtenerCategoriaDto>>> VerCategorias();
        Task<Response<ObtenerCategoriaDto>> VerUnaCategoria(int id);
        Task<Response<List<ObtenerCategoriaDto>>> VerCategoriaNombre(string nombre);
        Task<Response<ObtenerCategoriaDto>> CrearCategoria(CrearCategoriaDto nuevaCategoria);
        Task<Response<ObtenerCategoriaDto>> ActualizarCategoria(ActualizarCategoriaDto actualizarCategoria, int id);
        Task<Response<ObtenerCategoriaDto>> EliminarCategoria(int id);
    }
}
