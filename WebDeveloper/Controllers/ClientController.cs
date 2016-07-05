﻿using System.Net;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        //Con esto ya no se necsita llamar al contrsutros de la clase 
        //Ejemplo Single Inyector
        //Lo 
        //se instancia una sola vez porq en produccion en el IIS se carga una sola vez.
        //-> se comenta en contenbedores.
        //private ClientData _client = new ClientData();
        //
        //Se cambio el IdataAccess<client> y salio error abajo en el metodo GetClient REVISAR.
        //private IDataAccess<Client> _client;
        private ClientData _client;

        public ClientController(ClientData client)
        {
            _client = client;
        }
        // GET: Client
        public ActionResult Index()
        {
            ViewBag.Title = Resources.Resource.Client_Title;
            //control punto
            //return View(client.GetFakeData());
            return View(_client.GetList());
        }
        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        //sobre escribir el metodo
        public ActionResult Create(Client client)
        {
            //(ModelState.IsValid) ->validar que el estado del modelo sea valido
            //todo lo q se pone como dataanotation sea correcto
            //validacion de lado del cliente y del lado del servidor ->Buena practica
            if (ModelState.IsValid)
            {
                _client.Add(client);
                //puedo poner al controlador que deseo ir
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
            var client = _client.GetClient(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                if (_client.Update(client) > 0)
                    return RedirectToAction("index");
                return View(client);
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var client = _client.GetClient(id);
            if (client == null)
                RedirectToAction("index");
            return View(client);
        }
        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (_client.Delete(client) > 0)
                return RedirectToAction("index");
            return View(client);
        }
    }

}