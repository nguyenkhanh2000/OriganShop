using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AppManager.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    
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
        [HttpPost]
        public IActionResult GetData([FromBody] RequestModel req)
        {
            var query = _dbContext.CategoryEntities.Where(x => !x.IsDeleted);
            if (!string.IsNullOrEmpty(req.Freetext))
            {
                query = query.Where(x => x.Name.ToLower().Contains(req.Freetext));
            }
            var res = new ResponseModel<CategoryModel>();
            int skip = req.PageSize * req.Pagenumber - req.PageSize;
            res.TotalCount = query.Count();
            res.Data = query.Select(x => new CategoryModel()
            {
                Id = x.Id,
                Name = x.Name,
                Slug = x.Slug,
                CreatedDate = x.CreatedDate,
                CreatedBy = x.CreatedBy
            }).Skip(skip).Take(req.PageSize).ToList();
            return Json(res);
        }
        [HttpPost]
        public IActionResult AddOrUpdate(CategoryModel model)
        {
            if(model.Id == 0)
            {
                var entity = new CategoryEntity()
                {
                    Name = model.Name,
                    Slug = model.Slug,
                    CreatedBy = "khanh",
                    UpdatedBy = "khanh",
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                };
                _dbContext.CategoryEntities.Add(entity);
            }
            else
            {
                var entity = _dbContext.CategoryEntities.Find(model.Id);
                if(entity != null)
                {
                    entity.Name = model.Name;
                    entity.Slug = model.Slug;
                    entity.UpdatedDate = DateTime.Now;

                    _dbContext.CategoryEntities.Update(entity);
                }
            }
            var status = _dbContext.SaveChanges();
            return Json(status);
        }
    }
}
