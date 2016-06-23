using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData: BaseDataAccess<Product>
    {
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {ID=1,Description="ffff",Price=3.0,SellEndDate=DateTime.Now },
                new Product {ID=2,Description="gdfg",Price=0.0,SellEndDate=null }
            };
        }
        public Product GetProduct(int? id)
        {

            using (var dbContext = new WebContextDb())
            {
                return dbContext.products.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
