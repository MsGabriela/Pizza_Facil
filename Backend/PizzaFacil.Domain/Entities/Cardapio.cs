using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Entities
{
    public class Cardapio : Entity
    {
        public Cardapio()
        {
            
        }

        public Guid CategoriaId { get; private set; }

        public string Nome { get; private set; }
        public decimal Valor { get; private set; }

        /*EF Relation*/
        public Categoria Categoria { get; private set; }
        public List<ItensPedido> ItensPedido { get; private set; }
    }
}
