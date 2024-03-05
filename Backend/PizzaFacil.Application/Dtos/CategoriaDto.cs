using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Application.Dtos
{
    public class CategoriaDto
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }
    }
}
