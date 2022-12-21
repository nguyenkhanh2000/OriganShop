using System.Collections.Generic;

namespace AppManager.Models
{
    public class HomeViewModel
    {
       public List<CategoryModel> ListCategory { get; set; }
       
       public List<ProductModel> ListProduct { get; set; }
       public List<BlogModel> ListBlog { get; set; }
       public List<BannerModel> ListBanner { get; set; }
    }
}
