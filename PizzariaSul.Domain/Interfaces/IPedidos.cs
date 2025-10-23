using PizzariaSul.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Domain.Interfaces
{
    public interface IPedidos
    {
        Task<Pedidos> CriarPedido(Pedidos pedido);
        Task<Pedidos> BuscarPedido(int id);
        Task<bool> CancelarPedido(int id);
    }
}
