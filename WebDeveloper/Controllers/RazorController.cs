using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")] //Nuestro prefijo con el cual se va a ingresar va ser Razor (tabla ruteo)
    public class RazorController : Controller
    {
        // GET: Razor
        [Route] //toma por defecto a index 
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
        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {
            //todo actionresulkt tiene un retorno view.
            ViewBag.Date = date.ToShortDateString();
            return View();
        }
        [Route("Entry/{id:int}")]
        public string EntryId(int id)
        {
            return id.ToString();
        }
    }
}