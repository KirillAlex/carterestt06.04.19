using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    /// <summary>
    /// Този клас описва марка
    /// </summary>
    /// <remarks>
    ///     Автор: Кирилл Алексеев
    /// </remarks>
    public class Brand
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public string Image { get; set; }
        public virtual ICollection<BrandPost> BrandPosts { get; set; }

    }
}
