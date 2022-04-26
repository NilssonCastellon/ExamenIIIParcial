using Blazor.Data;
using Datos.Interfaces;
using Datos.Repositorio;
using Examen3parcial.Interfaces;
using Modelos;

namespace Examen3parcial.Servicios
{
    public class UsuarioServicio : IUsuarioServicios  
    {
        private readonly MySQLConfiguration _configuration;
        private IUsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
        }

        public async Task<bool> Actualizar(Usuario usuario)
        {
            return await usuarioRepositorio.Actualizar(usuario);
        }

        public async Task<bool> Eliminar(Usuario usuario)
        {
            return await usuarioRepositorio.Eliminar(usuario);
        }

        public async Task<IEnumerable<Usuario>> GetLista()
        {
            return await usuarioRepositorio.GetLista();
        }

        public async Task<Usuario> GetPorCodigo(string codigo)
        {
            return await usuarioRepositorio.GetPorCodigo(codigo);
        }

        public async Task<bool> Nuevo(Usuario usuario)
        {
            return await usuarioRepositorio.Nuevo(usuario);


        }

        public Task<bool> ValidaUsuario(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
