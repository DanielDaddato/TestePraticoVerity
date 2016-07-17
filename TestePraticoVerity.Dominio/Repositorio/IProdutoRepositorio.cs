using System.Collections.Generic;
using System.Threading.Tasks;
using TestePraticoVerity.Dominio.Entidades;

namespace TestePraticoVerity.Dominio.Repositorio
{
    public interface IProdutoRepositorio
    {
        Task<int> Adicionar(Produtos produto);
        IEnumerable<Produtos> ListarTodos();

    }
}
