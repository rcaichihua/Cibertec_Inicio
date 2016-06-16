using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name="sdsds" ,LastName="dsdsd"},
                new Client {Name="ee" ,LastName="dsdsd"},
                new Client {Name="33" ,LastName="dsdsd"},
                new Client {Name="33" ,LastName="dsdsd"},
                new Client {Name="hhhh" ,LastName="dsdsd"},
            };

            clients.ForEach(c => context.CLients.Add(c));
            context.SaveChanges();
        }
    }
}
