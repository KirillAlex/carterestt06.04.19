using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Този клас описва контекст за достъп до БД
    /// </summary>
    /// <remarks>
    ///     Автор: Петър Павлов
    /// </remarks>
    public class CarContext: DbContext
    {   
        public CarContext() : base("name=Carterest")
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandPost> BrandPosts { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
