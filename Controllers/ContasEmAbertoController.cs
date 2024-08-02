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
    }
}
