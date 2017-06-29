using System.Collections.Generic;

namespace StoreSpa.DataAccess {
    public interface IProductDal {
        IEnumerable<Product> GetProducts();
        Product Add(Product product);
        Product Get(string id);
        Product Delete(string id);
        Product Update(Product changes);
    }
}
