using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePraticoVerity.Infraestrutura.Servico;
using TestePraticoVerity.Dominio.Entidades;
using TestePraticoVerity.Models;

namespace TestePraticoVerity.Infra
{
    public class ProdutosInfra
    {
        public IEnumerable<Models.ProdutosDTO> ListaProdutos()
        {
            var produtos = new ProdutosServico().ListarTodos();
            List<ProdutosDTO> produtosDTO = new List<ProdutosDTO>();
            produtos.ToList().ForEach(p => {
                produtosDTO.Add(new ProdutosDTO
                {
                    ID = p.ID,
                    Nome = p.Nome,
                    Descricao = p.Descricao,
                    Categoria = ConverteCategoria(p.Categoria),
                    Preco = p.Preco,
                    Quantidade = p.Quantidade
                });
            });
            return produtosDTO;
        }

        private CategoriaDTO ConverteCategoria(Categoria categoria)
        {
            return new CategoriaDTO
            {
                ID = categoria.ID,
                Nome = categoria.Nome,
                Descricao = categoria.Descricao
            };
        }

        private Categoria ConverteCategoriaDTO(CategoriaDTO categoria)
        {
            return new Categoria
            {
                ID = categoria.ID,
                Nome = categoria.Nome,
                Descricao = categoria.Descricao
            };
        }

        public async Task<int> GravaProduto(ProdutosDTO produtoDTO)
        {
            var produto = new Produtos
            {
                ID = produtoDTO.ID,
                Nome = produtoDTO.Nome,
                Descricao = produtoDTO.Descricao,
                Preco = produtoDTO.Preco,
                Quantidade = produtoDTO.Quantidade,
                CategoriaId = produtoDTO.CategoriaId
            };
            return await new ProdutosServico().Adicionar(produto);
        }
    }
}
