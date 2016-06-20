using System;
using System.Net;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        private ProductData _product = new ProductData();
        // GET: Product
        public ActionResult Index()
        {
            return View(_product.GetList());
        }
        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Add(product);
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _product.GetProduct(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (_product.Update(product) > 0)
                    return RedirectToAction("index");
                return View(product);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var product = _product.GetProduct(id);
            if (product == null)
                RedirectToAction("index");
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (_product.Delete(product) > 0)
                return RedirectToAction("index");
            return View(product);
        }
    }
}