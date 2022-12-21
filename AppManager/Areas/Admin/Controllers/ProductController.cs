//using AppManager.Areas.Admin.Models;
using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;
using System.Security.Claims;

namespace AppManager.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,staff")]
    

    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index(string name, int pageNumber = 1)
        {
            // lấy tài khoản người dùng
            var claims = HttpContext.User.Identity as ClaimsIdentity;
            var accClaim = claims.FindFirst(ClaimTypes.NameIdentifier);
            ViewBag.Account = accClaim.Value;
            

            int pageSize = 5;
            var query = new ProductViewModel();
            query.ListProduct = _dbContext.ProductEntities
                .Where(x => string.IsNullOrEmpty(name) || x.Name.ToLower().Contains(name.Trim().ToLower()))
                .Select(x => new ProductModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    Price = x.Price,
                    OldPrice = x.OldPrice,
                    Description = x.Description,
                    SummaryContent = x.SummaryContent,
                    Quantity = x.Quantity,
                    Weight = x.Weight,
                    Unit = x.Unit,
                    CategoryId = x.CategoryId,
                    CreatedDate = x.CreatedDate,
                    UpdatedDate = x.UpdatedDate,
                    CreatedBy = x.CreatedBy,
                    UpdatedBy = x.UpdatedBy,
                    Status = x.Status,
                    IsDeleted = x.IsDeleted
                }).ToList();
            
            
            var totalCount = query.ListProduct.Count();
            ViewBag.pageCount = Math.Ceiling((decimal)totalCount/ pageSize);
            ViewBag.pageNumber = pageNumber;
            ViewBag.pageSize = pageSize;
            ViewBag.name = name;

            var listProduct = query.ListProduct.Skip(pageSize * pageNumber - pageSize).Take(pageSize).ToList();
            return View(listProduct);
        }
        public IActionResult AddOrUpdate(int id)
        {
            var viewmodel = new ProductViewModel();
            if(id > 0)
            {
                
                var entity = _dbContext.ProductEntities.Find(id);
                viewmodel = new ProductViewModel()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Slug = entity.Slug,
                    Price = entity.Price,
                    OldPrice = entity.OldPrice,
                    Description = entity.Description,
                    SummaryContent = entity.SummaryContent,
                    Quantity = entity.Quantity,
                    Weight = entity.Weight,
                    Unit = entity.Unit,
                    CategoryId = entity.CategoryId,
                    CreatedDate = entity.CreatedDate,
                    UpdatedDate = entity.UpdatedDate,
                    CreatedBy = entity.CreatedBy,
                    UpdatedBy = entity.UpdatedBy,
                    Status = entity.Status,
                    IsDeleted = entity.IsDeleted
                };
               
            }
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult AddOrUpdate(ProductModel model)
        {          
            if (!ModelState.IsValid)
            {
                var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                TempData["error"] = error.FirstOrDefault();
                return Redirect("~/Admin/Product/AddOrUpdate");
            }

            if(model.Id > 0)
            {
                // code sửa
                var entity = _dbContext.ProductEntities.Find(model.Id);
                if(entity != null)
                {
                    entity.Name = model.Name;
                    entity.Slug = model.Slug;
                    entity.Price = model.Price;
                    entity.OldPrice = model.OldPrice;
                    entity.Description = model.Description;
                    entity.SummaryContent = model.SummaryContent;
                    entity.Quantity = model.Quantity;
                    entity.Weight = model.Weight;
                    entity.Unit = model.Unit;
                    entity.IsDeleted = model.IsDeleted;
                    entity.Status = model.Status;
                    entity.UpdatedBy = model.UpdatedBy;
                    entity.CreatedBy = model.CreatedBy;
                    entity.UpdatedDate = model.UpdatedDate;
                    entity.CreatedDate = model.CreatedDate;
                    entity.CategoryId = model.CategoryId;

                    _dbContext.ProductEntities.Update(entity);
                }
            }
            else
            {
                // thêm mới
                var entity = new ProductEntity()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Slug = model.Slug,
                    Price = model.Price,
                    OldPrice = model.OldPrice,
                    Description = model.Description,
                    SummaryContent = model.SummaryContent,
                    Quantity = model.Quantity,
                    Weight = model.Weight,
                    Unit = model.Unit,
                    CategoryId = model.CategoryId,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CreatedBy = model.CreatedBy,
                    UpdatedBy = model.UpdatedBy,
                    Status = model.Status,
                    IsDeleted = model.IsDeleted
                   
                };

                _dbContext.ProductEntities.Add(entity);
                
            }
            _dbContext.SaveChanges();

            return Redirect("~/Admin/Product/Index");
           
        }
        public IActionResult Delete(int id)
        {
            var model = _dbContext.ProductEntities.Find(id);
            _dbContext.ProductEntities.Remove(model);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
