using PizzaFacil.Domain.Models;

namespace PizzaFacil.Domain.Entities
{
    public class MetodoPagamento : Entity
    {
        public MetodoPagamento()
        {
            
        }

        public string Nome { get; private set; }

        /*EF Relations*/
        public List<Pedido> Pedidos { get; private set; }

    }
}
