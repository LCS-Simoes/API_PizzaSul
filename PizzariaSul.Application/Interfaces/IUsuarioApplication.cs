using PizzariaSul.Application.DTOs.UsuariosDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Application.Interfaces
{
    public interface IUsuarioApplication
    {
        Task<UsuarioResponse> ExecuteAsync(CadastrarRequest request);
        Task<UsuarioResponse> Deletar(int id);
        Task<UsuarioResponse> BuscarId(int id);
    }
}
