using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Entities
{
    public class Pedido : Entity
    {
        public Pedido()
        {
            
        }

        public string NumeroDoPedido { get; private set; }
        public int QuantidadePizzas { get; private set; }
        public decimal ValorTotal { get; private set; }

        /*EF Relations*/
        public MetodoPagamento MetodoPagamento { get; private set; }
        public StatusPedido StatusPedido { get; private set; }
        public List<ItensPedido> ItensPedido { get; private set; }

    }
}
