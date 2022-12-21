using System.ComponentModel.DataAnnotations.Schema;

namespace AppManager.Entities
{

    [Table("ProductImage")]
    public class ProductImageEntity:BaseEntity
    {
        public int ProductId { get; set; }
        public int FileId { get; set; }
        public bool IsAvatar { get; set; }
        public string ImageMore { get; set; }
    }
}
