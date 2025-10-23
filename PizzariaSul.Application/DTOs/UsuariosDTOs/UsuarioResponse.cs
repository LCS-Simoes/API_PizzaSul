using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSul.Application.DTOs.UsuariosDTOs
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Celular { get; set; }
        public string? Bairro { get; set; }
        public string? Rua { get; set; }
        public string? NumeroCasa { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }
    }
}
