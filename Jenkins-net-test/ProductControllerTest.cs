using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jenkins_net_test
{
    using System.Web.Mvc;

    using Jenkins_net_demo.Controllers;

    /// <summary>
    /// The product controller test.
    /// </summary>
    [TestClass]
    public class ProductControllerTest
    {
        /// <summary>
        /// The test details view.
        /// </summary>
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);

        }
    }
}
