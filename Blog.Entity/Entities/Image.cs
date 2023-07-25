using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Image : EntityBase { 
        public Guid Id { get; set; }

        public string FileName { get; set; }

        public string FileType { get; set; }//jpeg, png vs.

        public ICollection<Article> Articles { get; set;}
    }
}
