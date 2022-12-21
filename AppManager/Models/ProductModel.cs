using System;
using System.ComponentModel.DataAnnotations;

namespace AppManager.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Độ dài tên không phù hợp")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug không được để trống")]
        public string Slug { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Giá cũ không được để trống")]
        public decimal OldPrice { get; set; }

        [Required(ErrorMessage = "Tóm tắt không được để trống")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Nội dung sản phẩm không được để trống")]
        public string SummaryContent { get; set; }

        [Required(ErrorMessage = "Số lượng sản phẩm không được để trống")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Cân nặng sản phẩm không được để trống")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Đơn vị sản phẩm không được để trống")]
        public string Unit { get; set; }

        [Required(ErrorMessage = "Danh mục sản phẩm không được để trống")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Ngày tạo không được để trống")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Ngày cập nhật không được để trống")]
        public DateTime UpdatedDate { get; set; }

        [Required(ErrorMessage = "Người tạo không được để trống")]
        public string CreatedBy { get; set; }

        [Required(ErrorMessage = "Người cập nhật không được để trống")]
        public string UpdatedBy { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public int Status { get; set; }

        [Required(ErrorMessage = "Xóa không được để trống")]
        public bool IsDeleted { get; set; }
        public string Avatar { get; set; }
        
    }
}
