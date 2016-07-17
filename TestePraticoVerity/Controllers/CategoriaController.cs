using System.Web.Mvc;
using TestePraticoVerity.Infra;
using TestePraticoVerity.Models;

namespace TestePraticoVerity.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var categorias = new CategoriaInfra().ListaCategorias();
            return View(categorias);
        }

        public ActionResult Adicionar()
        { 
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Gravar(CategoriaDTO categoria)
        {

            var retorno = new CategoriaInfra().GravarCategoria(categoria);
            return RedirectToAction("Index");
        }

    }
}