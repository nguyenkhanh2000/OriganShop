﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AppManager.Entities
{

    [Table("Category")]
    public class CategoryEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Image { get; set; }
    }
}
