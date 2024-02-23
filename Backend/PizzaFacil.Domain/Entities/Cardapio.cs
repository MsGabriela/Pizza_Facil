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

        public Guid CategoriaId { get; set; }

        public string Nome { get; set; }
        public decimal Valor { get; set; }

        /*EF Relation*/
        public Categoria Categoria { get; set; }
    }
}
