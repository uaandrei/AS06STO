namespace StoreSpa.Business.Models {
    public class ProductModelChanges {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ProductModel ApplyChanges(ProductModel model) {
            model.Name = Name;
            model.Description = Description;
            model.Price = Price;
            return model;
        }
    }
}
