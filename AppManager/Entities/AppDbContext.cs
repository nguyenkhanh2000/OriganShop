using Microsoft.EntityFrameworkCore;
using System;

namespace AppManager.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<ProductEntity> ProductEntities { get; set; }
        public DbSet<CategoryEntity> CategoryEntities { get; set; }
        public DbSet<FileManageEntity> FileManageEntities { get; set; }
        public DbSet<ProductImageEntity> ProductImageEntities { get; set; }
        public DbSet<BlogEntity> BlogEntities { get; set; }
        public DbSet<BannerEntity> BannerEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
                .Property(x => x.Id).ValueGeneratedOnAdd(); 
        }
        

    }
}
