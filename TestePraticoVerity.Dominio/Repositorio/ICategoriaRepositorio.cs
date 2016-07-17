using System.Collections.Generic;
using TestePraticoVerity.Dominio.Entidades;
using System.Threading.Tasks;

namespace TestePraticoVerity.Dominio.Repositorio
{
    public interface ICategoriaRepositorio
    {
        Task<int> Adicionar(Categoria categoria);
        IEnumerable<Categoria> ListarTodos();
        Task<Categoria> BuscaPorID(int IdCategoria);
    }
}
