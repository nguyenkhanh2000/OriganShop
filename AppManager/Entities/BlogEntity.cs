using System.ComponentModel.DataAnnotations.Schema;

namespace AppManager.Entities
{
    [Table("Blog")]
    public class BlogEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        
    }
}
