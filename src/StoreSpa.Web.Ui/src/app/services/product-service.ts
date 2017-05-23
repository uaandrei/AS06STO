import { Injectable } from "@angular/core";

import { Product } from "../models/product";

@Injectable()
export class ProductService {
    products = [
        new Product("1", "product 1"),
        new Product("2", "product 2"),
        new Product("3", "product 3"),
        new Product("4", "product 4"),
        new Product("5", "product 5")
    ];

    public GetProducts(): Product[] {
        return this.products;
    }

    public GetProduct(id: String) {
        return this.products.find(p => p.id === id);
    }

    public AddProduct(product: Product) {
        this.products.push(product);
    }
}