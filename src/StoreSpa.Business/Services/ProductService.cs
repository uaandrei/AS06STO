using StoreSpa.Business.Mappers;
using StoreSpa.Business.Models;
using StoreSpa.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace StoreSpa.Business.Services {
    public class ProductService : IProductService {
        private readonly IProductDal _dal;
        private readonly IProductMapper _mapper;

        public ProductService(IProductDal dal, IProductMapper mapper) {
            _dal = dal;
            _mapper = mapper;
        }

        public IEnumerable<ProductModel> GetProducts() {
            return _dal.GetProducts().Select(p =>
                new ProductModel {
                    Id = p.Id.ToString(),
                    Description = p.Description,
                    Name = p.Name,
                    Price = p.Price.Value
                }
            );
        }

        public ProductModel Add(ProductModel model) {
            var data = _mapper.ToData(model);
            var addedData = _dal.Add(data);
            var addedModel = _mapper.ToModel(addedData);
            return addedModel;
        }

        public ProductModel GetProduct(string id) {
            var data = _dal.Get(id);
            var model = _mapper.ToModel(data);
            return model;
        }

        public ProductModel Update(string id, ProductModelChanges changes) {
            var model = new ProductModel() {
                Id = id
            };
            model = changes.ApplyChanges(model);
            var data = _mapper.ToData(model);
            var updatedData = _dal.Update(data);
            var updatedModel = _mapper.ToModel(updatedData);
            return updatedModel;
        }

        public ProductModel Delete(string id) {
            var data = _dal.Delete(id);
            var model = _mapper.ToModel(data);
            return model;
        }
    }
}
