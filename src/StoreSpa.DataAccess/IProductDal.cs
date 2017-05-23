using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSpa.DataAccess
{
    public interface IProductDal
    {
        IEnumerable<Product> GetProducts();
        void Add(Product product);
    }
}
