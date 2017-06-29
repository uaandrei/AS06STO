using Microsoft.AspNetCore.Mvc;
using StoreSpa.Business.Models;
using StoreSpa.Business.Services;
using System.Collections.Generic;

namespace StoreSpa.WebApi.Controllers {
    [Route("api/[controller]")]
    public class ProductsController : Controller {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService) {
            _productService = productService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<ProductModel> Get() {
            return _productService.GetProducts();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ProductModel Get(string id) {
            return _productService.GetProduct(id);
        }

        // POST api/values
        [HttpPost]
        public ProductModel Post([FromBody]ProductModel value) {
            var product = _productService.Add(value);
            return product;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ProductModel Put(string id, [FromBody]ProductModelChanges value) {
            var product = _productService.Update(id, value);
            return product;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ProductModel Delete(string id) {
            var product = _productService.Delete(id);
            return product;
        }
    }
}
