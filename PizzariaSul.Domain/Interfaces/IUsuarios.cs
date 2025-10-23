using PizzariaSul.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Domain.Interfaces
{
    public interface IUsuarios
    {
        Task<Usuario> CadastrarUsuario(Usuario usuario);
        Task<Usuario> AtualizarUsuario(Usuario usuario, int id);
        Task<bool> DeletarUsuario(int id);
    }
}
