using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePraticoVerity.Dominio.Entidades;
using TestePraticoVerity.Dominio.Repositorio;
using TestePraticoVerity.Infraestrutura.Data;

namespace TestePraticoVerity.Infraestrutura.Servico
{
    public class ProdutosServico : IProdutoRepositorio
    {
        public async Task<int> Adicionar(Produtos produto)
        {
            using (TestePraticoContext Db = new TestePraticoContext())
            {
                Db.Produtos.Add(produto);
                return await Db.SaveChangesAsync();
            }
        }

        public IEnumerable<Produtos> ListarTodos()
        {
            using (TestePraticoContext Db = new TestePraticoContext())
            {
                var produtos = Db.Produtos.Include("Categoria").ToList();
                return produtos;
            }
        }
    }
}
