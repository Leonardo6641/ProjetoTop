using Microsoft.AspNetCore.Mvc;

namespace ProjetoTop.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
