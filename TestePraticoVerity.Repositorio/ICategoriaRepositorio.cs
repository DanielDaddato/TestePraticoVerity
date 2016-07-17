using System;
using System.Collections.Generic;
using TestePraticoVerity.Dominio.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoVerity.Repositorio
{
    public interface ICategoriaRepositorio
    {
        void Adicionar(Categoria categoria);
        void Salvar(Categoria categoria);
        IEnumerable<Categoria> ListarTodos();
        Categoria BuscarPorID(int idCategoria);
    }
}
