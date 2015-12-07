using System.Web.Mvc;

namespace Jenkins_net_demo.Controllers
{
    using System;

    public class ProductController : Controller
    {
        // GET: Product
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public ActionResult Index()
        {
            // Add action logic here
            throw new NotImplementedException();
        }

        /// <summary>
        /// The details.
        /// </summary>
        /// <param name="Id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Details(int Id)
        {
            return this.View("Details");
        }
    }
}