using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePraticoVerity.Models
{
    public class ProdutosDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Favor preencher Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Favor preencher Preco")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Favor preencher Quantidade")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Favor Selecionar Categoria")]
        [Display(Name = "Categoria")]
        public CategoriaDTO Categoria { get; set; }

        public int CategoriaId { get; set; }
    }
}
