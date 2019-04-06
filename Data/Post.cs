using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Този клас описва публикация
    /// </summary>
    /// <remarks>
    ///     Автор: Бюлент Казали
    /// </remarks>
    public class Post
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string FileName { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<BrandPost> BrandPosts { get; set; }

    }
}
