using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Entities
{
    public class ItensAdicionais : Entity
    {
        public ItensAdicionais()
        {
            
        }

        public decimal ValorDoAdicional { get; private set; }
        public string Descricao { get; private set; }

        /*EF Relations*/
        public ItensPedido ItemPedido { get; private set; }
        public CardapioAdicionais CardapioAdicional { get; private set; }
    }
}
