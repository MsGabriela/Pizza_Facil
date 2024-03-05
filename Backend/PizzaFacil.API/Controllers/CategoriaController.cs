using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaFacil.Application.Dtos;
using PizzaFacil.Application.Interfaces.Services;
using PizzaFacil.Domain.Models;

namespace PizzaFacil.API.Controllers
{

    [Route("api/categoria")]
    public class CategoriaController : MainController
    {

        private readonly ICategoriaService _categoriaService;
        private readonly IMapper _mapper;

        public CategoriaController(ICategoriaService categoriaService,
                                   INotificador notificador,
                                   IMapper mapper) : base(notificador)
        {
            _categoriaService = categoriaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDto>>> ObterTodos()
        {
            return CustomResponse(_mapper.Map<IEnumerable<CategoriaDto>>(await _categoriaService.ObterTodasCategorias()));
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CategoriaDto>> ObterPorId(Guid id)
        {
            var categoriaDto = _mapper.Map<CategoriaDto>(await _categoriaService.ObterCategoriaPorId(id));

            if(categoriaDto == null) return CustomResponse();

            return CustomResponse(categoriaDto);        
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaDto>> Adicionar(CategoriaDto categoriaDto)
        {
            if(!ModelState.IsValid) return CustomResponse(ModelState);

            await _categoriaService.Adicionar(_mapper.Map<Categoria>(categoriaDto));

            return CustomResponse();
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Atualizar(Guid id, CategoriaDto categoriaDto)
        {
            if(id != categoriaDto.Id) return CustomResponse();

            var categoriaAtualizacao = await _categoriaService.ObterCategoriaPorId(id);

            categoriaAtualizacao.AtualizarNome(categoriaDto.Nome);

            await _categoriaService.Atualizar(categoriaAtualizacao);

            return CustomResponse();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<CategoriaDto>> Excluir(Guid id)
        {
            var categoriaDto = _mapper.Map<CategoriaDto>(await _categoriaService.ObterCategoriaPorId(id));

            if(categoriaDto == null) return CustomResponse();

            await _categoriaService.Remover(id);

            return CustomResponse();
        }
    }
}
