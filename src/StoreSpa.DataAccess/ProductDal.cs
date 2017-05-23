using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSpa.DataAccess
{
    public class ProductDal : IProductDal
    {
        public IEnumerable<Product> GetProducts()
        {
            using (var context = new ProductsContainer())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (var context = new ProductsContainer())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
