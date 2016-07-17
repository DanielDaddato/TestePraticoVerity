using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePraticoVerity.Dominio.Entidades;

namespace TestePraticoVerity.Repositorio
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produtos produto);
        void Salvar(Produtos produto);
        IEnumerable<Produtos> ListarTodos();
        Produtos BuscarPorID(int idProduto);
    }
}
