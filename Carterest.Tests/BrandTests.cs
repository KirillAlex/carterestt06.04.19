using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carterestt.Controllers;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Moq;
using Data;

namespace Carterest.Tests
{
    [TestFixture]
    public class BrandTests
    {
        [Test]
        public void GetReturnsBrand()
        {
            var controller = new BrandsController();
            var mock = new Mock<CarContext>();
            mock.Setup(p => p.Brands.Find(1));
            BrandsController brandsController = new BrandsController();
            var result = brandsController.Details(1);


        }
    }
}
