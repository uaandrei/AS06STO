using StoreSpa.DataAccess;
using System.Collections.Generic;
using System;
using System.Linq;

namespace StoreSpa.Business.Tests {
    public class DummyProductDal : IProductDal {
        private List<Product> _products = new List<Product>();

        public int Count {
            get {
                return _products.Count;
            }
        }

        public Product Add(Product product) {
            _products.Add(product);
            return product;
        }

        public Product Delete(string id) {
            var product = _products.Single(p => p.Id.ToString() == id);
            _products.Remove(product);
            return product;
        }

        public Product Get(string id) {
            return _products.Single(p => p.Id.ToString() == id);
        }

        public IEnumerable<Product> GetProducts() {
            return _products;
        }

        public Product Update(Product changes) {
            var product = _products.Single(p => p.Id == changes.Id);
            _products.Remove(product);
            _products.Add(changes);
            return changes;
        }
    }
}
