using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AppManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(long categoryId,int pageNumber = 1,string sort = "")
        {
            int pageSize = 6;
            

            var data = new ProductViewModel();
            data.ListCategory = _dbContext.CategoryEntities.Select(x => new CategoryModel()
            {
                Name = x.Name,
                Id = x.Id,
            }).ToList();
            data.ListProduct = _dbContext.ProductEntities.Select(x => new ProductModel()
            {
                Name = x.Name,
                Id = x.Id,
                Price = x.Price
            }).ToList();
            var query = from a in _dbContext.ProductEntities
                        join b in _dbContext.CategoryEntities
                        on a.CategoryId equals b.Id
                        where a.CategoryId == categoryId || categoryId == 0 
                        
                        select new Product_CateModel()
                        {
                            Id = a.Id,
                            Name = a.Name,
                            CategoryName = b.Name,
                            Price = a.Price,
                            OldPrice = a.OldPrice,
                            Avatar = a.Avatar,
                        };
            
            switch (sort)
            {
                case "default":
                    break;
                case "price":
                    query = query.OrderBy(x => x.Price);
                    break;
                case "name":
                    query = query.OrderBy(x => x.Name);
                    break;
                default:
                    break;
            }         
            var totalCount = query.Count();
            ViewBag.pageCount = Math.Ceiling((decimal)totalCount / pageSize);
            ViewBag.pageNumber = pageNumber;
            ViewBag.pageSize = pageSize;
            ViewBag.sort = sort;

            data.ListProductCate = query.Skip(pageSize * pageNumber - pageSize).Take(pageSize).ToList();
            return View(data);
        }      
        public IActionResult Detail(long categoryId, int Id)
        {
            
            var viewmodel = new ProductViewModel();
            if (Id > 0)
            {

                var entity = _dbContext.ProductEntities.Find(Id);
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
                    IsDeleted = entity.IsDeleted,
                    Avatar = entity.Avatar
                    
                };

            }
            return View(viewmodel);
        }


        public IActionResult Cart()
        {
            

            return View();
        }
        
        [HttpPost]
        public IActionResult getCartData([FromBody] ProductViewModel model)
        {
            var products = _dbContext.ProductEntities.Where(x => model.Ids.Contains(x.Id));
            return Json(products);
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var prods = _dbContext.ProductEntities.ToList();
            return Json(prods);
        }
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var categories = _dbContext.CategoryEntities.ToList();
            return Json(categories);
        }
    }
}
