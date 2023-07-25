using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Article:EntityBase
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int ViewCount { get; set; }//Makale kaç kere görüntülendi

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }//Entity Category'den maplediğimizi anlıyor.

        public Guid ImageId { get; set; }

        public Image Image { get; set; }

       
    }
}
