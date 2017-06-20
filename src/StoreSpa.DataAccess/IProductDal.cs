using System.Collections.Generic;

namespace StoreSpa.DataAccess {
    public interface IProductDal {
        IEnumerable<Product> GetProducts();
        void Add(Product product);
    }
}
