using Modelos;

namespace Examen3parcial.Interfaces
{
    public interface IUsuarioServicios
    {
        Task<bool> Nuevo(Usuario usuario);
        Task<bool> Actualizar(Usuario usuario);
        Task<bool> Eliminar(Usuario usuario);
        Task<IEnumerable<Usuario>> GetLista();
        Task<Usuario> GetPorCodigo(string codigo);
        Task<bool> ValidaUsuario(Login login);

    }
}
