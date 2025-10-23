using PizzariaSul.Application.DTOs.UsuariosDTOs;
using PizzariaSul.Application.Interfaces;
using PizzariaSul.Domain.Interfaces;


namespace PizzariaSul.Application.UseCases
{
    public class UsuarioUseCase : IUsuarioApplication
    {
        private readonly IUsuarios _usuarioReposotiro;

        public UsuarioUseCase(IUsuarios usuarioReposotiro)
        {
            _usuarioReposotiro = usuarioReposotiro;
        }

        public Task<UsuarioResponse> BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponse> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponse> ExecuteAsync(CadastrarRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
