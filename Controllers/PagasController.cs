using ContaHoueseMvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace ContaHoueseMvc.Controllers
{
    public class PagasController : Controller
    {
        private readonly ContaDbContext _context;
        public PagasController(ContaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {   
            return View();
        }
    }
}
