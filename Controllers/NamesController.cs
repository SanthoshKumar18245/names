using Microsoft.AspNetCore.Mvc;
using NameStorageApp.Data;
using System.Threading.Tasks;

namespace NameStorageApp.Controllers
{
    public class NamesController : Controller
    {
        private readonly AppDbContext _context;

        public NamesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                _context.Names.Add(new NameEntry { Name = name });
                await _context.SaveChangesAsync();
                ViewBag.Message = "Name saved successfully!";
            }
            return View();
        }
    }
}
