using Aurora.Models;
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
            var endereco = _enderecoRepositorio.BuscarTodos();
            return View(endereco);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            var endereco = _enderecoRepositorio.BuscarPorId(id);
            return View(endereco);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            var endereco = _enderecoRepositorio.BuscarPorId(id);
            return View(endereco);
        }

        [HttpPost]
        public IActionResult Criar(EnderecoModel enderecoModel)
        {
            if (ModelState.IsValid)
            {
                _enderecoRepositorio.Adicionar(enderecoModel);
                return RedirectToAction("Index");
            }

            return View(enderecoModel);
        }

        [HttpPost]
        public IActionResult Alterar(EnderecoModel enderecoModel)
        {
            if (ModelState.IsValid)
            {
                _enderecoRepositorio.Atualizar(enderecoModel);
                return RedirectToAction("Index");
            }

            return View(enderecoModel);
        }


        public IActionResult Apagar(int id)
        {
            var endereco = _enderecoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
