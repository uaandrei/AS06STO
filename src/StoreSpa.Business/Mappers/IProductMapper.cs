using StoreSpa.Business.Models;
using StoreSpa.DataAccess;

namespace StoreSpa.Business.Mappers {
    public interface IProductMapper {
        ProductModel ToModel(Product productData);
        Product ToData(ProductModel productModel);
    }
}
