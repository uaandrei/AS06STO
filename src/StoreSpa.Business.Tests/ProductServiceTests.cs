using StoreSpa.Business.Mappers;
using StoreSpa.Business.Models;
using StoreSpa.Business.Services;
using Xunit;

namespace StoreSpa.Business.Tests {
    public class ProductServiceTests {
        private readonly DummyProductDal _dummyDal;
        private readonly ProductService _sut;

        public ProductServiceTests() {
            _dummyDal = new DummyProductDal();
            _sut = new ProductService(_dummyDal, new ProductMapper());
        }

        [Fact]
        public void CountShouldBeEqualToNumberOfNewProductsAdded() {
            // arrange
            var newProduct1 = new ProductModel();
            var newProduct2 = new ProductModel();

            // act
            _sut.Add(newProduct1);
            _sut.Add(newProduct2);

            // assert
            Assert.Equal(2, _dummyDal.Count);
        }
    }
}
