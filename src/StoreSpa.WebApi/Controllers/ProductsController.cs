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
        public string Get(int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
