using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Domain.Entities
{
    public class StatusPedido : Entity
    {
        public StatusPedido()
        {
            
        }

        public string Descricao { get; private set; }

        /*EF Relations*/
        public List<Pedido> Pedidos { get; private set; }
    }
}
