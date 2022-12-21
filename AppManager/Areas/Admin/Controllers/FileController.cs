using AppManager.Entities;
using AppManager.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace AppManager.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _enviroment;
        private readonly AppDbContext _dbContext;

        public FileController(IWebHostEnvironment environment,
            AppDbContext dbContext)
        {
            _enviroment = environment;
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UploadFile(IFormFile file)
        {
            if (file == null)
                return Json(new { status = "error" });

            string foderUploads = Path.Combine(_enviroment.WebRootPath, "img");
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string fullPath = Path.Combine(foderUploads, fileName);
            using(var stream = new FileStream(fullPath, FileMode.Open))
            {
                file.CopyTo(stream);
            }
            
            
            //Thêm file
            var fileEntity = new FileManageEntity()
            {
                Name = file.FileName,
                FilePath = "/img/" + fileName,
                FileType = "image",
                UpdatedDate = DateTime.Now,
                CreatedDate = DateTime.Now
            };

            _dbContext.FileManageEntities.Add(fileEntity);
            var status = _dbContext.SaveChanges();
            if(status == 0)
                return Json(new { status = "error" });

            var model = new FileModel()
            {
                Id = fileEntity.Id,
                FilePath = fileEntity.FilePath,
                FileName = fileEntity.Name
            };

            return Json(new {status = "success", 
                fileInfo = model
            });
            
        }
    }
}
