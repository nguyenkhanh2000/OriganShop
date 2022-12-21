using AppManager.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace AppManager.Models
{
    public class ProductImageModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int FileId { get; set; }

        [Required(ErrorMessage = "không được để trống")]
        public bool? IsAvatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int Status { get; set; }

        public string ImageMore { get; set; }
        public bool IsDeleted { get; set; }
    }
}
