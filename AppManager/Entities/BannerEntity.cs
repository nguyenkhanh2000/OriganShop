using System.ComponentModel.DataAnnotations.Schema;

namespace AppManager.Entities
{
    [Table("Banner")]
    public class BannerEntity:BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
    }
}
