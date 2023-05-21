using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyProject.DAL;
using YummyProject.Models;

namespace YummyProject.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {

        private readonly AppDbContext _appContext;

        public MenuViewComponent(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = await _appContext.Products
                                                 .OrderByDescending(s => s.Id)
                                                 .Take(3)
                                                 .Include(s => s.Category)
                                                 .ToListAsync();

            return View(products);

        }
    }
}
