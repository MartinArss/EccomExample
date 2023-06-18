namespace Eccom.Services.CategoriaService
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CategoriaService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Response<List<ObtenerCategoriaDto>>> VerCategorias()
        {
            var serviceResponse = new Response<List<ObtenerCategoriaDto>>();
            var dbCategorias = await _context.Categorias.ToListAsync();
            serviceResponse.Data = dbCategorias.Select(_mapper.Map<ObtenerCategoriaDto>).ToList();
            serviceResponse.Message = "Lista de categorias";

            return serviceResponse;
        }

        public async Task<Response<ObtenerCategoriaDto>> VerUnaCategoria(int id)
        {
            var serviceResponse = new Response<ObtenerCategoriaDto>();
            var dbCategoria = await _context.Categorias.FirstOrDefaultAsync(c => c.IdCategoria == id);

            serviceResponse.Data = _mapper.Map<ObtenerCategoriaDto>(dbCategoria);

            return serviceResponse;
        }

        public async Task<Response<ObtenerCategoriaDto>> CrearCategoria(CrearCategoriaDto nuevaCategoria)
        {
            var serviceResponse = new Response<ObtenerCategoriaDto>();
            try
            {
                var categoria = _mapper.Map<Categoria>(nuevaCategoria);
                _context.Categorias.Add(categoria);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<ObtenerCategoriaDto>(categoria);
                serviceResponse.Message = "Categoria creada exitosamente.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Error al crear la categoria. " + ex.Message;
                // Aquí puedes agregar más lógica de manejo de errores según tus necesidades
            }

            return serviceResponse;
        }

        public async Task<Response<ObtenerCategoriaDto>> ActualizarCategoria(ActualizarCategoriaDto actualizarCategoria, int id)
        {
            var serviceResponse = new Response<ObtenerCategoriaDto>();
            try
            {
                var dbCategoria = await _context.Categorias.FindAsync(id);
                if (dbCategoria == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = $"No se encontró el personaje con el Id: '{id}'";
                    return serviceResponse;
                }

                _mapper.Map(actualizarCategoria, dbCategoria);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<ObtenerCategoriaDto>(dbCategoria);
            }
            catch (DbUpdateException ex)
            {
                // Manejar excepciones específicas de la base de datos (por ejemplo, violaciones de restricciones)
                serviceResponse.Success = false;
                serviceResponse.Message = "Error al actualizar el personaje en la base de datos. " + ex.Message;
                // Aquí se puede agregar más lógica de manejo de errores
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                serviceResponse.Success = false;
                serviceResponse.Message = "Error al actualizar el personaje. " + ex.Message;
                // Aquí se puede agregar más lógica de manejo de errores
            }

            return serviceResponse;
        }

        public async Task<Response<ObtenerCategoriaDto>> EliminarCategoria(int id)
        {
            var serviceResponse = new Response<ObtenerCategoriaDto>();
            try
            {
                var dbCategoria = await _context.Categorias.FindAsync(id);
                if (dbCategoria == null)
                    throw new Exception($"No se encontró el personaje con el Id: '{id}'");

                _context.Categorias.Remove(dbCategoria);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<ObtenerCategoriaDto>(dbCategoria);
                serviceResponse.Message = "Personaje eliminado exitosamente.";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Error al eliminar el personaje. " + ex.Message;
                // Aquí puedes agregar más lógica de manejo de errores según tus necesidades
            }

            return serviceResponse;
        }

        public async Task<Response<List<ObtenerCategoriaDto>>> VerCategoriaNombre(string nombre)
        {
            var serviceResponse = new Response<List<ObtenerCategoriaDto>>();

            var dbCategorias = await _context.Categorias
                .Where(c => c.NomCat.Contains(nombre))
                .ToListAsync();

            serviceResponse.Data = dbCategorias.Select(_mapper.Map<ObtenerCategoriaDto>).ToList();
            serviceResponse.Message = "Lista de categorias por nombre";

            return serviceResponse;
        }
    }
}
