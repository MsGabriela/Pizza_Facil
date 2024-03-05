using PizzaFacil.Application.Interfaces.Repositories;
using PizzaFacil.Application.Interfaces.Services;
using PizzaFacil.Domain.Models;
using PizzaFacil.Domain.Validations;

namespace PizzaFacil.Application.Services
{
    public class CategoriaService : BaseService, ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly INotificador _notificador;

        public CategoriaService(ICategoriaRepository categoriaRepository,
                                INotificador notificador)
        {
            _categoriaRepository = categoriaRepository;
            _notificador = notificador;

        }

        public async Task<Categoria> ObterCategoriaPorId(Guid id)
        {
            return await _categoriaRepository.ObterPorId(id);
        }

        public async Task<IEnumerable<Categoria>> ObterTodasCategorias()
        {
            return await _categoriaRepository.ObterTodos();
        }

        public async Task Adicionar(Categoria categoria)
        {
            var validator = new CategoriaValidator();
            var results = validator.Validate(categoria);

            if(!results.IsValid)
            {
                foreach(var error in results.Errors)
                {
                    _notificador.Handle(new Notificacao(error.ErrorMessage));
                }

                return;
            }

            await _categoriaRepository.Adicionar(categoria);
        }

        public async Task Atualizar(Categoria categoria)
        {
            var validator = new CategoriaValidator();
            var results = validator.Validate(categoria);

            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    _notificador.Handle(new Notificacao(error.ErrorMessage));
                }

                return;
            }

            await _categoriaRepository.Atualizar(categoria);
        }

        public async Task Remover(Guid id)
        {
            await _categoriaRepository.Remover(id);
        }

        public void Dispose()
        {
            _categoriaRepository?.Dispose();
        }
    }
}
