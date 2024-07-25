using ContaHoueseMvc.Data;
using ContaHoueseMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaHoueseMvc.Controllers
{
    public class ContasEmAbertoController : Controller
    {
        private readonly ContaDbContext _context;

        public ContasEmAbertoController(ContaDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            return View();
        }

        public IActionResult AdicionarConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarConta(ContaModel conta)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
