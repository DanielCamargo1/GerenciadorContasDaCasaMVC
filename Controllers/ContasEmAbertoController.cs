using ContaHoueseMvc.Data;
using ContaHoueseMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContaHoueseMvc.Controllers
{
    public class ContasEmAbertoController : Controller
    {
        private readonly ContaDbContext _context;

        public ContasEmAbertoController(ContaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contas = _context.Contas.ToList();
            return View(contas);
        }

        [HttpGet]
        public IActionResult AdicionarConta()
        {
            return View();
        }

        [HttpGet]

        public IActionResult ExcluirConta(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var doacao = _context.Contas.FirstOrDefault(x => x.Id == id);

            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);

        }

        [HttpPost]
        public IActionResult AdicionarConta(ContaModel conta)
        {
            if (!ModelState.IsValid)
            {
                return View(conta);
            }
            _context.Contas.Add(conta);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ExcluirConta( ContaModel conta)
        {

            if(conta != null)
            {
                _context.Contas.Remove(conta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
