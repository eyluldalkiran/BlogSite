using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)//Mapping için kullandığımız fonksiyon
        {
           
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//tüm mapping sınıfları burada tanımlamış oluyoruz(GetExecutingAssembly sayesinde)
                                                  //Map işlemlerini burada da yapabiliriz ama map sınıfları daha clean kod yazmamızı sağlıyor

        }
    }
}
