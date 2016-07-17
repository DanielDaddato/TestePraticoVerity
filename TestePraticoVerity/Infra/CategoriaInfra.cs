using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePraticoVerity.Dominio.Entidades;
using TestePraticoVerity.Infraestrutura.Servico;
using TestePraticoVerity.Models;

namespace TestePraticoVerity.Infra
{
    public class CategoriaInfra
    {
        public IEnumerable<CategoriaDTO> ListaCategorias()
        {
             var categorias = new CategoriaServico().ListarTodos();
            List<CategoriaDTO> categoriaDTO = new List<CategoriaDTO>();
            categorias.ToList().ForEach(c => categoriaDTO.Add(new CategoriaDTO
            {
                ID = c.ID,
                Nome = c.Nome,
                Descricao = c.Descricao
            })
            );

            return categoriaDTO;
        }

        public async Task<int> GravarCategoria(CategoriaDTO categoriaDTO)
        {
            var categoria = new Categoria()
            {
                Nome = categoriaDTO.Nome,
                Descricao = categoriaDTO.Descricao,
            };
            return await new CategoriaServico().Adicionar(categoria);
        }
    }
}
