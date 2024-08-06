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

        public List<ContaModel> Pagas = new List<ContaModel>();

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
                return NotFound("O porblema esta no id recebido! Entre em contato com o Desenvolvedor");
            }
            var conta = _context.Contas.Find(id);
            if (conta == null)
            {
                return NotFound();
            }
            return View(conta);
        }

        [HttpGet]

        public IActionResult EditarConta(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("O porblema esta no id recebido! Entre em contato com o Desenvolvedor");
            }
            var conta = _context.Contas.Find(id);
            if (conta == null)
            {
                return NotFound();
            }
            return View(conta);
        }

        [HttpGet]
        public IActionResult PagarConta()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContasPagas()  
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
      
        [HttpPost]
        public IActionResult EditarConta( ContaModel conta)
        {
            if (ModelState.IsValid)
            {
                _context.Contas.Update(conta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conta);
        }

        [HttpPost]
        public IActionResult ExcluirConta(ContaModel conta)
        {

            if (conta != null)
            {
                _context.Contas.Remove(conta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        2
        [HttpPost]
        public IActionResult PagarConta(ContaModel conta)
        {
            if(conta != null)
            {
                var situacao = conta.Situacao;
                if(situacao == false)
                {
                    situacao = true;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

    }
}
