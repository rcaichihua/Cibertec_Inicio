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
            clients.ForEach(c => context.clients.Add(c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product {Name="Product 1", ProductNumber="ZG-W091-S",Color="blue",ListPrice=152.45M,SellEndDate=DateTime.Parse("2016-09-22")},
                new Product {Name="Product 2", ProductNumber="PG-W031-S",Color="yellow",ListPrice=22.45M,SellEndDate=DateTime.Parse("2016-05-01")},
                new Product {Name="Product 3", ProductNumber="OG-W051-S",Color="red",ListPrice=982.45M,SellEndDate=new Nullable<DateTime>()},
                new Product {Name="Product 4", ProductNumber="SG-W011-S",Color="white",ListPrice=12.45M,SellEndDate=DateTime.Parse("2016-09-22")},
                new Product {Name="Product 8", ProductNumber="TG-T091-S",Color="blue",ListPrice=192.45M,SellEndDate=new Nullable<DateTime>()}
            };
            products.ForEach(c => context.products.Add(c));
            context.SaveChanges();
        }
    }
}

