using ContaHoueseMvc.Data;
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

    }
}
