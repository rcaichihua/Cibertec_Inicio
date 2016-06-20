using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData :BaseDataAccess<Client>
    {
        //public List<Client> GetFakeData()
        //{
        //    return new List<Client>
        //    {
        //        new Client { ID = 1, Name = "Juan",   LastName = "Perez" },
        //        new Client { ID = 1, Name = "Raul", LastName = "Ruidiaz"}
        //    };
        //}

        //public List<Client> GetList()
        //{
        //    //using -> crea y al final destruye el objeto
        //    using (var dbContext = new WebContextDb())
        //    {
        //        return dbContext.CLients.ToList();
        //    }
        //}

        //public List<Client> GetListId(int? id)
        //{
        //    using (var dbContext = new WebContextDb())
        //    {
        //        //set apunta a la tabla que se va a definir
        //        Client client = dbContext.CLients.Find(id);
        //        if (client == null)
        //        {
        //            //return HttpNotFound();
        //        }
        //        //return View(movie);
        //        return dbContext.Set<Client>().ToList();
        //    }
        //}

        public Client GetClient(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.clients.FirstOrDefault(x => x.ID == id);
            }
        }

        //public object Entry(Client client)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
