using PizzariaSul.Application.DTOs.UsuariosDTOs;
using PizzariaSul.Domain.Entidades;
using PizzariaSul.Domain.Interfaces;


namespace PizzariaSul.Application.UseCases
{
    public class UsuarioUseCase 
    {
        private readonly IUsuarios _usuarioReposotiro;

        public UsuarioUseCase(IUsuarios usuarioReposotiro)
        {
            _usuarioReposotiro = usuarioReposotiro;
        }

        public async Task<UsuarioResponse> ExecuteAsync(CadastrarRequest request) //Pode dar erro verificar posteriormente
        {
            var usuario = new Usuario
            {
                Nome = request.Nome,
                Celular = request.Celular,
                Bairro = request.Bairro,
                Rua = request.Rua,
                NumeroCasa = request.NumeroCasa,
                Cidade = request.Cidade,
                Cep = request.Cep
            };

            var criado = await _usuarioReposotiro.CadastrarUsuario(usuario);

            return new UsuarioResponse
            {
                Id = criado.Id,
                Nome = criado.Nome,
                Celular = criado.Celular,
                Bairro = criado.Bairro,
                Rua = criado.Rua,
                NumeroCasa = criado.NumeroCasa,
                Cidade = criado.Cidade,
                Cep = criado.Cep
            };
        }

        public async Task<UsuarioResponse> AtualizarUsuario(int id, AtualizarRequest request)
        {
            var usuario = await _usuarioReposotiro.BuscarId(id);
            if (usuario == null) return null;

            var atualizado = await _usuarioReposotiro.AtualizarUsuario(usuario, id);

            return new UsuarioResponse
            {
                Id = atualizado.Id,
                Nome = atualizado.Nome,
                Celular = atualizado.Celular,
                Bairro = atualizado.Bairro,
                Rua = atualizado.Rua,
                NumeroCasa = atualizado.NumeroCasa,
                Cidade = atualizado.Cidade,
                Cep = atualizado.Cep
            };
        }

        //Remover pós testes
        public async Task<UsuarioResponse> BuscarId(int id)
        {
            var usuario = await _usuarioReposotiro.BuscarId(id);
            if (usuario == null) return null;

            return new UsuarioResponse
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Celular = usuario.Celular,
                Bairro = usuario.Bairro,
                Rua = usuario.Rua,
                NumeroCasa = usuario.NumeroCasa,
                Cidade = usuario.Cidade,
                Cep = usuario.Cep
            };
            
        }

        public async Task<bool> Deletar(int id)
        {
            return await _usuarioReposotiro.DeletarUsuario(id);
        }
    }
}
