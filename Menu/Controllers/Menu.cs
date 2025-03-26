using Microsoft.AspNetCore.Mvc;
using Menu.Data;
using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.Controllers
{
    
    public class MenuController : Controller
    {
        private readonly MenuContext _context;
        public MenuController(MenuContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index( string SearchString)
        {
            var dishes = from d in _context.Dishes
                       select d;
            var dish = await _context.Dishes.ToListAsync();
            if(!string.IsNullOrEmpty(SearchString))
            {
                dishes = dishes.Where(d => d.Name.Contains(SearchString));
                return View(await dishes.ToListAsync());
            }
            return View(await dishes.ToListAsync());
        }
        public async Task<IActionResult> Details (int? id)
        {
            var dish = await _context.Dishes
                .Include(di => di.DishIngredient)
                .ThenInclude(i => i.Ingredient)
                .FirstOrDefaultAsync(x => x.Id == id);
            if(dish==null)
            {
                return NotFound();
            }
            return View(dish);
        }
    }
}
