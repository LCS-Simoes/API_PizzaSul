using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PizzariaSul.Application.DTOs.CepDTOs;
using PizzariaSul.Application.Integracao.Interfaces;

namespace PizzariaSul.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegração;

        public CepController(IViaCepIntegracao viaCepIntegração)
        {
            _viaCepIntegração = viaCepIntegração;
        }

        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> ListarEndereco(string cep)
        {
            var response = await _viaCepIntegração.ObterCep(cep);

            if (response == null) return BadRequest("CEP não encontrado");

            return Ok(response);
        }
    }
}
