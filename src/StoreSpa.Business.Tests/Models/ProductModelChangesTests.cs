using StoreSpa.Business.Models;
using Xunit;

namespace StoreSpa.Business.Tests.Models {
    public class ProductModelChangesTests {
        private readonly ProductModelChanges _sut;

        public ProductModelChangesTests() {
            _sut = new ProductModelChanges();
        }

        [Fact]
        public void ApplyChangesShouldChangeModelObjectAccordingly() {
            // arrange
            var model = new ProductModel {
                Description = "initial",
                Name = "init",
                Price = 10.0M
            };
            var changes = new ProductModelChanges {
                Description = "changed",
                Name = "change",
                Price = 20.0M
            };

            // act
            model = changes.ApplyChanges(model);

            // assert
            Assert.Equal("changed", model.Description);
            Assert.Equal("change", model.Name);
            Assert.Equal(20.0M, model.Price);
        }
    }
}
