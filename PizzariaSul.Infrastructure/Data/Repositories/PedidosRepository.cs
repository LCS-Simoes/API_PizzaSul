using Microsoft.EntityFrameworkCore;
using PizzariaSul.Domain.Entidades;
using PizzariaSul.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Infrastructure.Data.Repositories
{
    public class PedidosRepository : IPedidos
    {
        private readonly PizzariaSulDbContext _dbcontext;

        public PedidosRepository(PizzariaSulDbContext context)
        {
            _dbcontext = context;
        }

        public async Task<Pedidos?> BuscarPedido(int id)
        {
            return await _dbcontext.Pedidos.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Pedidos> CriarPedido(Pedidos pedido)
        {
            await _dbcontext.Pedidos.AddAsync(pedido);
            await _dbcontext.SaveChangesAsync();
            return pedido;
        }

        public async Task<bool> CancelarPedido(int id)
        {
            Pedidos pedidosId = await BuscarPedido(id);
            if (pedidosId == null)
            {
                throw new Exception($"Pedido {id} não foi encontrado no banco de dados");
            }

            _dbcontext.Pedidos.Remove(pedidosId);
            await _dbcontext.SaveChangesAsync();
            return true;
        } 
    }
}
