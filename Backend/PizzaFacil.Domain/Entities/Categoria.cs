using PizzaFacil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }

        /*EF Relations*/
        public List<Cardapio> Pizzas { get; private set; }
    }
}

