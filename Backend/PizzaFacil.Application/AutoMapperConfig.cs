using AutoMapper;
using PizzaFacil.Application.Dtos;
using PizzaFacil.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFacil.Application
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
        }
    }
}
