using PizzaFacil.Application.Interfaces.Repositories;
using PizzaFacil.Domain.Models;
using PizzaFacil.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Infra.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(PizzaFacilDbContext context) : base(context) { }
    }
}
