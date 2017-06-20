using StoreSpa.Business.Models;
using StoreSpa.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreSpa.Business.Services {
    public class ProductService : IProductService {
        private IProductDal _dal;

        public ProductService(IProductDal dal) {
            _dal = dal;
        }

        public IEnumerable<ProductModel> GetProducts() {
            return _dal.GetProducts().Select(p =>
                new ProductModel {
                    Id = p.Id.ToString(),
                    Description = p.Description,
                    Name = p.Name,
                    Price = p.Price.Value
                }
            );
        }

        public void Add(ProductModel value) {
            _dal.Add(new Product {
                Description = value.Description,
                Name = value.Name,
                Price = value.Price
            });
        }
    }
}
