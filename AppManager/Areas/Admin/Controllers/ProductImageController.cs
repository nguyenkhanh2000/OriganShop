using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Data;
using System.Linq;

namespace AppManager.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,staff")]
    public class ProductImageController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductImageController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var data = _dbContext.ProductImageEntities.Select(x => new ProductImageModel()
            {
                Id = x.Id,
                ProductId=x.ProductId,
                FileId = x.FileId,
                //IsAvatar = x.IsAvatar,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                CreatedBy = x.CreatedBy,
                UpdatedBy = x.UpdatedBy,
                Status = x.Status,
                IsDeleted = x.IsDeleted,
                ImageMore = x.ImageMore
            }).ToList();
            return View(data);
        }
        
    }
}
