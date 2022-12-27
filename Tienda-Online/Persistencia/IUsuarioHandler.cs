using Modelo;

namespace Persistencia
{
    public interface IUsuarioHandler : ICRUD<Usuario>
    {
        Usuario LoginUser(string email, string contraseña);
    }
}