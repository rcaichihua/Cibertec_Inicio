using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    //con dbContext -> contexto de datos.
    public class WebContextDb : DbContext
    {
        //ctor snip tab tab
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
            Database.SetInitializer(new WebDeveloperInitializer());
        }
        //indicar la tabla a la que se va a relacionar
        //DbSet mapear al objeto Clients(asi se llamara la tabla en la base de datos)
        public DbSet<Client> clients { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //evitar poner en plural a los objetos sin agregar(es)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }

        //public System.Data.Entity.DbSet<WebDeveloper.Models.Account.LoginViewModel> LoginViewModels { get; set; }

        //public System.Data.Entity.DbSet<WebDeveloper.Models.Account.LoginViewModel> LoginViewModels { get; set; }
    }
}
