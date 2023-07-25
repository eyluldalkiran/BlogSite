using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //Data Seedleme: Test ederken kullanabilmek için oluşturuyoruz
            builder.HasData(
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net core deneme makalesi",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi quis semper ipsum, a viverra lacus. Sed eleifend rutrum ligula sed venenatis. Proin quis eros quis mauris euismod mollis. Fusce aliquet sem malesuada urna scelerisque dictum. Proin id odio non neque gravida facilisis. Donec molestie euismod dolor eu molestie. Vivamus dictum pulvinar dignissim. Proin blandit faucibus nulla. Donec dictum ante et massa congue commodo. Donec quis purus purus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Ut nec dolor id ante venenatis sagittis. Fusce id tortor tristique, posuere magna sed, gravida metus. Suspendisse potenti. Nam elementum pulvinar orci, tempus tristique ante tempus non.",
                ViewCount = 15,
                CategoryId=Guid.Parse("01FA1372-98B1-476D-9FD5-7C3450D25139"),
                ImageId=Guid.Parse("38681E98-5FD8-4AD5-B318-D658F8D05913"),
                CreatedBy="Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio makalesi",
                Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi quis semper ipsum, a viverra lacus. Sed eleifend rutrum ligula sed venenatis. Proin quis eros quis mauris euismod mollis. Fusce aliquet sem malesuada urna scelerisque dictum. Proin id odio non neque gravida facilisis. Donec molestie euismod dolor eu molestie. Vivamus dictum pulvinar dignissim. Proin blandit faucibus nulla. Donec dictum ante et massa congue commodo. Donec quis purus purus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Ut nec dolor id ante venenatis sagittis. Fusce id tortor tristique, posuere magna sed, gravida metus. Suspendisse potenti. Nam elementum pulvinar orci, tempus tristique ante tempus non.",
                ViewCount = 15,
                CategoryId= Guid.Parse("36D3C733-C838-4CAA-A507-23287FBAF903"),
                ImageId=Guid.Parse("0FB825B6-540D-4726-A3F0-F08BF69E6FB4"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }
            );
        }
           
    }
}
