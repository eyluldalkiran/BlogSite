using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("01FA1372-98B1-476D-9FD5-7C3450D25139"),
                    Name = "ASP.net",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "Admin Test",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("36D3C733-C838-4CAA-A507-23287FBAF903"),
                    Name = "Visual Studio",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "Admin Test",
                    IsDeleted = false
                }
            );
        }
    }
}
