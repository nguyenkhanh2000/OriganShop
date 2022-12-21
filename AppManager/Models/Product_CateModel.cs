using System;

namespace AppManager.Models
{
    public class Product_CateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public string Description { get; set; }

        public string SummaryContent { get; set; }

        public int Quantity { get; set; }

        public double Weight { get; set; }

        public string Unit { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public string Avatar { get; set; }
    }
}
