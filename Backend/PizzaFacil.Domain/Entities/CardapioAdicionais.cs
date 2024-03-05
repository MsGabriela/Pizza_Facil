using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Entities
{
    public class CardapioAdicionais : Entity
    {
        public CardapioAdicionais()
        {
            
        }

        public string Nome { get; private set; }
        public decimal Valor { get; private set; }

        /*EF Relations*/
        public List<ItensAdicionais> ItensAdicionais { get; private set; }
    }
}
