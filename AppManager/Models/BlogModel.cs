using System;

namespace AppManager.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
