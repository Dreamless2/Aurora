using Aurora.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Aurora.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Models.EnderecoModel enderecoModel)
        {
            _enderecoRepositorio.Adicionar(enderecoModel);
            return RedirectToAction("Index");
        }

    }
}
