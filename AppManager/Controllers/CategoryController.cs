using AppManager.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AppManager.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
