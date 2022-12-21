using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AppManager.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _dbContext;

        public BlogController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var data = _dbContext.BlogEntities.Select(x => new BlogModel()
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title,
                Image = x.Image,
                Content = x.Content,
                CreatedDate = x.CreatedDate
            }).ToList();
            return View(data);
        }
        public IActionResult DetailBlog(int Id)
        {
            var viewmodel = new BlogModel();
            if (Id > 0)
            {
                var entity = _dbContext.BlogEntities.Find(Id);
                viewmodel = new BlogModel()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Title = entity.Title,
                    Image = entity.Image,
                    CreatedDate = entity.CreatedDate,
                    Content = entity.Content,
                };
            }
            return View(viewmodel);
        }
    }
}
