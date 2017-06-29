using StoreSpa.Business.Models;
using System.Collections.Generic;

namespace StoreSpa.Business.Services {
    public interface IProductService {
        IEnumerable<ProductModel> GetProducts();
        ProductModel GetProduct(string id);
        ProductModel Add(ProductModel product);
        ProductModel Update(string id, ProductModelChanges changes);
        ProductModel Delete(string id);
    }
}
