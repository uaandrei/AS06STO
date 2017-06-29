using StoreSpa.Business.Models;
using StoreSpa.DataAccess;
using System;

namespace StoreSpa.Business.Mappers {
    public class ProductMapper : IProductMapper {
        public Product ToData(ProductModel productModel) {
            return new Product {
                Id = Convert.ToInt32(productModel.Id),
                Description = productModel.Description,
                Name = productModel.Name,
                Price = productModel.Price
            };
        }

        public ProductModel ToModel(Product productData) {
            return new ProductModel {
                Id = productData.Id.ToString(),
                Description = productData.Description,
                Name = productData.Name,
                Price = productData.Price ?? 0.0M
            };
        }
    }
}
