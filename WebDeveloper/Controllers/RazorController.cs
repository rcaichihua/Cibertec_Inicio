using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            var client = new List<Client>
            {
              new Client { ID = 1, Name = "Juan",   LastName = "Perez",DateCreation=DateTime.Now },
              new Client { ID = 2, Name = "Raul", LastName = "Ruidiaz",DateCreation=null}
            };
            return View(client);
        }

        public ActionResult Product()
        {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }
    }
}