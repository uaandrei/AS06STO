using StoreSpa.Business.Mappers;
using StoreSpa.Business.Models;
using StoreSpa.DataAccess;
using Xunit;

namespace StoreSpa.Business.Tests.Mappers {
    public class ProductMapperTests
    {
        private readonly ProductMapper _sut;

        public ProductMapperTests() {
            _sut = new ProductMapper();
        }

        [Fact]
        public void ToDataShouldMapModelBackToDataObject() {
            // arrange
            var model = new ProductModel {
                Description = "test",
                Name = "name",
                Price = 5.5M
            };

            // act
            var data = _sut.ToData(model);

            // assert
            Assert.Equal("test", data.Description);
            Assert.Equal("name", data.Name);
            Assert.Equal(5.5M, data.Price);
        }

        [Fact]
        public void ToModelShouldMapDataBackToModelObject() {
            // arrange
            var data = new Product {
                Description = "test",
                Name = "name",
                Price = 5.5M
            };

            // act
            var model = _sut.ToModel(data);

            // assert
            Assert.Equal("test", model.Description);
            Assert.Equal("name", model.Name);
            Assert.Equal(5.5M, model.Price);
        }
    }
}
