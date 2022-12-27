using Microsoft.AspNetCore.Mvc;
using Modelo;
using Persistencia;
using Servicios;
using Servicios.Implementacion;

namespace Tienda_Online.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        public Usuario Inicio([FromBody] Usuario usuario)
        {
            return usuarioService.Login(usuario.Email, usuario.Contraseña);
        }
    }
}
