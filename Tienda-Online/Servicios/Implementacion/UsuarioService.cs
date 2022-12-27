using Modelo;
using Persistencia;
using Persistencia.implementacion;

namespace Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioHandler usuarioHandler;

        public UsuarioService(IUsuarioHandler usuarioHandler)
        {
            this.usuarioHandler = usuarioHandler;
        }

        public Usuario Login(string email, string contraseña)
        {
            var resultado = usuarioHandler.LoginUser(email, contraseña);
            resultado.Contraseña = "";

            return resultado;
        }
    }
}