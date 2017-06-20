using StoreSpa.DataAccess;
using System.Collections.Generic;

namespace StoreSpa.Business.Tests {
    public class DummyProductDal : IProductDal {
        private List<Product> _products = new List<Product>();

        public int Count {
            get {
                return _products.Count;
            }
        }

        public void Add(Product product) {
            _products.Add(product);
        }

        public IEnumerable<Product> GetProducts() {
            return _products;
        }
    }
}
