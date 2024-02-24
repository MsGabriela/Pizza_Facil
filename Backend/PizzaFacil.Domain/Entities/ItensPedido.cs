using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Entities
{
    public class ItensPedido : Entity
    {
        public ItensPedido()
        {
            
        }

        public decimal ValorDoItem { get; private set; }
        public string Observacoes { get; private set; }
        
        /*EF Relations*/
        public Pedido Pedido { get; private set; }
        public Cardapio Cardapio { get; private set; }
        public List<ItensAdicionais> ItensAdicionais { get; private set; }
    }
}
