using PizzaFacil.Domain.Models;

namespace PizzaFacil.Application.Interfaces.Services
{
    public interface ICategoriaService : IDisposable
    {
        Task<Categoria> ObterCategoriaPorId(Guid id);
        Task<IEnumerable<Categoria>> ObterTodasCategorias();
        Task Adicionar(Categoria categoria);
        Task Atualizar(Categoria categoria);
        Task Remover(Guid id);
    }
}
