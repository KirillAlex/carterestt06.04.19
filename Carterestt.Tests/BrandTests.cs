// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using Carterestt.Controllers;
using NUnit.Framework;


namespace Carterestt.Tests
{
    [TestFixture]
    public class BrandTests
    {
        [Test]
        public void GetReturnsBrand()
        {
            BrandsController brandsController = new BrandsController();
            var result = brandsController.Details(1);

        }
    }
}
