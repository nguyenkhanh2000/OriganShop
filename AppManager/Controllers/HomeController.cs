using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AppManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.ListCategory = _dbContext.CategoryEntities.Select(x => new CategoryModel
            {
                Id = x.Id,
                Name = x.Name,
                Image = x.Image
            }).ToList();
            model.ListProduct = _dbContext.ProductEntities.Select(x => new ProductModel
            {
                Id = x.Id,
                Name =x.Name
            }).ToList();
            model.ListBlog = _dbContext.BlogEntities.Select(x => new BlogModel
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title,
                Image = x.Image,
                Content = x.Content,
                CreatedDate = x.CreatedDate               
            }).ToList();
            model.ListBanner = _dbContext.BannerEntities.Select(x => new BannerModel
            {
                Id = x.Id,
                Name = x.Name,
                Image = x.Image
            }).ToList();
            return View(model);
        }
                        
        
        
        //public IActionResult GetListProduct(long categoryId)
        //{
        //    var listProduct = _dbContext.ProductEntities.ToList();
        //    var listCategory = _dbContext.CategoryEntities.ToList();
        //    var model = from a in listProduct
        //                join b in listCategory
        //                on a.CategoryId equals b.Id
        //                where a.CategoryId == categoryId
        //                select new ProductViewModel()
        //                {
        //                    CateName = b.Name,
        //                    Id = a.Id,
        //                    Name = a.Name,
        //                    Slug = a.Slug,
        //                    Price = a.Price,
        //                    OldPrice = a.OldPrice,
        //                    Description = a.Description,
        //                    SummaryContent = a.SummaryContent,
        //                    Quantity = a.Quantity,
        //                    Weight = a.Weight,
        //                    Unit = a.Unit
        //                };
        //    return View(model);
        //}
    }
}
