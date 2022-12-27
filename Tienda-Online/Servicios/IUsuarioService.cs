using Modelo;

namespace Servicios
{
    public interface IUsuarioService
    {
        Usuario Login(string email, string contraseña);
    }
}