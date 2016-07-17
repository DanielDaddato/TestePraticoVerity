using System.ComponentModel.DataAnnotations.Schema;

namespace TestePraticoVerity.Dominio.Entidades
{
    public class Produtos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria {get; set;}


    }
}
