using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyProject.DAL;
using YummyProject.Models;

namespace YummyProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}
