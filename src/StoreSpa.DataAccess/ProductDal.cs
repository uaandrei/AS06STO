using System.Collections.Generic;
using System.Linq;

namespace StoreSpa.DataAccess {
    public class ProductDal : IProductDal {
        public IEnumerable<Product> GetProducts() {
            using (var context = new ProductContext()) {
                return context.Products.ToList();
            }
        }

        public Product Add(Product product) {
            using (var context = new ProductContext()) {
                context.Products.Add(product);
                context.SaveChanges();
            }
            return product;
        }

        public Product Get(string id) {
            using (var context = new ProductContext()) {
                return context.Products.Single(p => p.Id.ToString().Equals(id));
            }
        }

        public Product Delete(string id) {
            using (var context = new ProductContext()) {
                var data = context.Products.Single(p => p.Id.ToString().Equals(id));
                context.Products.Remove(data);
                context.SaveChanges();
                return data;
            }
        }

        public Product Update(Product changes) {
            using (var context = new ProductContext()) {
                var data = context.Products.Single(p => p.Id.ToString().Equals(changes.Id));
                data.Description = changes.Description;
                data.Name = changes.Name;
                data.Price = changes.Price;
                context.SaveChanges();
                return data;
            }
        }
    }
}
