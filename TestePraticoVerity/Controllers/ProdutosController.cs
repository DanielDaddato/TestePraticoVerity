using System.Threading.Tasks;
using System.Web.Mvc;
using TestePraticoVerity.Infra;
using TestePraticoVerity.Models;

namespace TestePraticoVerity.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Index()
        {
            var produtos = new ProdutosInfra().ListaProdutos();
            return View(produtos);
        }

        public ActionResult Adicionar()
        {
            var produtos = new ProdutosDTO();       
            return View(produtos);
        }
        [HttpPost]
        public async Task<RedirectToRouteResult> Gravar(ProdutosDTO produto)
        {
            var retorno = await new ProdutosInfra().GravaProduto(produto);
            return RedirectToAction("Index");
        }

        public JsonResult Categorias()
        {
            var categorias = new CategoriaInfra().ListaCategorias();
            return Json(categorias, JsonRequestBehavior.AllowGet);
            
        }
    }
}