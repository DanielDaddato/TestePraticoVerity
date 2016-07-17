using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePraticoVerity.Dominio.Entidades;
using TestePraticoVerity.Dominio.Repositorio;
using TestePraticoVerity.Infraestrutura.Data;
using System.Data.Entity;

namespace TestePraticoVerity.Infraestrutura.Servico
{
    public class CategoriaServico : ICategoriaRepositorio
    {
        public async Task<int> Adicionar(Categoria categoria)
        {
            using (TestePraticoContext Db = new TestePraticoContext())
            {
                Db.Categoria.Add(categoria);
               return await Db.SaveChangesAsync();
            }
                
        }

        public async Task<Categoria> BuscaPorID(int IdCategoria)
        {
            using (TestePraticoContext Db = new TestePraticoContext())
            {
                return await Db.Categoria.Where(c => c.ID == IdCategoria)
                    .Select(c => c).FirstOrDefaultAsync();                
            }
        }

        public IEnumerable<Categoria> ListarTodos()
        {
            using (TestePraticoContext Db = new TestePraticoContext())
            {
                var categorias = Db.Categoria.ToList();
                return categorias;
            }
        }
    }
}
