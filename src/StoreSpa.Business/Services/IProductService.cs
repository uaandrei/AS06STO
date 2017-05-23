using StoreSpa.Business.Models;
using System.Collections.Generic;

namespace StoreSpa.Business.Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetProducts();
        void Add(ProductModel value);
    }
}
