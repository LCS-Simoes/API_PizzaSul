using Microsoft.EntityFrameworkCore;
using PizzariaSul.Domain.Entidades;
using PizzariaSul.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Infrastructure.Data.Repositories
{
    public class UsuarioRepository : IUsuarios
    {
        private readonly PizzariaSulDbContext _dbcontext;

        public UsuarioRepository(PizzariaSulDbContext context)
        {
            _dbcontext = context;
        }

        public async Task<Usuario?> BuscarId(int id)
        {
            return await _dbcontext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Usuario?> BuscarLogin(string celular)
        {
            return await _dbcontext.Usuarios.FirstOrDefaultAsync(x => x.Celular == celular);
        }

        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            await _dbcontext.Usuarios.AddAsync(usuario);
            await _dbcontext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> AtualizarUsuario(Usuario usuario, int id)
        {
            Usuario usuarioId = await BuscarId(id);
            if (usuarioId == null)
            {
                throw new Exception($"Usuário {id} não foi encontrado no banco de dados");
            }

            usuarioId.Nome = usuario.Nome;
            usuarioId.Celular = usuario.Celular;
            usuarioId.Bairro = usuario.Bairro;
            usuarioId.Rua = usuario.Rua;
            usuarioId.Cidade = usuario.Cidade;
            usuarioId.Cep = usuario.Cep;
            usuarioId.NumeroCasa = usuario.NumeroCasa;

            _dbcontext.Usuarios.Update(usuarioId);
            await _dbcontext.SaveChangesAsync();

            return usuarioId;
        }

        public async Task<bool> DeletarUsuario(int id)
        {
            Usuario usuarioId = await BuscarId(id);

            if(usuarioId == null)
            {
                throw new Exception($"Usuário {id} não foi encontrado no banco de dados");
            }

            _dbcontext.Usuarios.Remove(usuarioId);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
