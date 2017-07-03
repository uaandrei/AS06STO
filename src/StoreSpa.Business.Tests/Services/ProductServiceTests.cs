using StoreSpa.Business.Mappers;
using StoreSpa.Business.Models;
using StoreSpa.Business.Services;
using System.Linq;
using Xunit;

namespace StoreSpa.Business.Tests.Services {
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

        [Fact]
        public void AddProductShouldReturnAddedProduct() {
            // arrange
            var product = new ProductModel {
                Id = "1",
                Description = "test",
                Name = "t",
                Price = 100.99M
            };

            // act
            var actual = _sut.Add(product);

            // assert
            Assert.Equal("1", actual.Id);
            Assert.Equal("test", actual.Description);
            Assert.Equal("t", actual.Name);
            Assert.Equal(100.99M, actual.Price);
        }

        [Fact]
        public void UpdateShouldReturnUpdatedProduct() {
            // arrange
            var existingProduct = new ProductModel {
                Id = "1",
                Description = "test",
                Name = "t",
                Price = 100.99M
            };
            _sut.Add(existingProduct);
            var updates = new ProductModelChanges {
                Description = "test_U",
                Name = "t_U",
                Price = 111.99M
            };

            // act
            var actual = _sut.Update("1", updates);

            // assert
            Assert.Equal("1", actual.Id);
            Assert.Equal("test_U", actual.Description);
            Assert.Equal("t_U", actual.Name);
            Assert.Equal(111.99M, actual.Price);
        }

        [Fact]
        public void GetProductShouldReturnAddedProduct() {
            // arrange
            _sut.Add(new ProductModel {
                Id = "1",
                Description = "test",
                Name = "t",
                Price = 100.99M
            });

            // act
            var actual = _sut.GetProduct("1");

            // assert
            Assert.Equal("1", actual.Id);
            Assert.Equal("test", actual.Description);
            Assert.Equal("t", actual.Name);
            Assert.Equal(100.99M, actual.Price);
        }

        [Fact]
        public void GetProductsShouldReturnAllAddedProducts() {
            // arrange
            _sut.Add(new ProductModel {
                Id = "1",
                Description = "test",
                Name = "t",
                Price = 100.99M
            });
            _sut.Add(new ProductModel {
                Id = "2",
                Description = "test2",
                Name = "t1",
                Price = 102.99M
            });

            // act
            var products = _sut.GetProducts().ToList();

            // assert
            Assert.Equal(2, products.Count);
            Assert.NotNull(products.SingleOrDefault(
                   p => p.Id == "1" 
                   && p.Description == "test"
                   && p.Name == "t"
                   && p.Price == 100.99M
            ));
            Assert.NotNull(products.SingleOrDefault(
                   p => p.Id == "2" 
                   && p.Description == "test2"
                   && p.Name == "t1"
                   && p.Price == 102.99M
            ));
        }

        [Fact]
        public void DeleteByIdShouldRemoveAndReturnProduct() {
            // arrange
            _sut.Add(new ProductModel {
                Id = "1"
            });
            _sut.Add(new ProductModel {
                Id = "2"
            });

            // act
            var actual = _sut.Delete("2");

            // assert
            Assert.Equal(1, _dummyDal.Count);
            Assert.Equal("2", actual.Id);
        }
    }
}
