using PizzariaSul.Domain.Enum;


namespace PizzariaSul.Domain.Entidades
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string? Sabor {  get; set; }
        public int UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }    
        public SatatusEnum Status { get; set; }
        public float Preco {  get; set; }

    }
}
