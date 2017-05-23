using Microsoft.Practices.Unity;
using StoreSpa.Business.Models;
using StoreSpa.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoreSpa.Web.Api.Controllers
{
    public class ProductController : ApiController
    {
        [Dependency]
        public IProductService ProductService { get; set; }

        // GET: api/
        public IEnumerable<ProductModel> Get()
        {
            return ProductService.GetProducts();
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]ProductModel value)
        {
            ProductService.Add(value);
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]ProductModel value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
