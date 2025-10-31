using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzariaSul.Application.DTOs.UsuariosDTOs;
using PizzariaSul.Application.UseCases;

namespace PizzariaSul.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioUseCase _usuarios;

        public UsuarioController(UsuarioUseCase _usuarioCase)
        {
            _usuarios = _usuarioCase;
        }


        //Procurando usuario
        [HttpGet]
        public async Task<ActionResult> BuscarID(int id)
        {
            var usuario = await _usuarios.BuscarId(id);
            return Ok(usuario);
        }

        //Criação de usuario
        [HttpPost("Cadastrar")]
        public async Task<ActionResult> Cadastrar([FromBody] CadastrarRequest request) 
        {
            var usuario = await _usuarios.ExecuteAsync(request);
            return Ok(usuario);
        }

        //Atualização Usuario
        [HttpPut("Atualizar")]
        public async Task<ActionResult> Atualizar(int id, [FromBody] AtualizarRequest request)
        {
            var usuario = await _usuarios.AtualizarUsuario(id, request);
            return Ok(usuario);
        }


        //Deletando perfil
        [HttpDelete("Deletar")]
        public async Task<ActionResult> Deletar(int id)
        {
            var resultado = await _usuarios.Deletar(id);

            if (resultado)
                return NoContent();

            return NotFound();
        }
    }
}
