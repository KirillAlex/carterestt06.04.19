using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Този клас описва връзка между марка и публикация
    /// </summary>
    /// <remarks>
    ///     Автор: Бюлент Казали
    /// </remarks>
    public class BrandPost
    {   
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int PostId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Post Post { get; set; }

    }
}
