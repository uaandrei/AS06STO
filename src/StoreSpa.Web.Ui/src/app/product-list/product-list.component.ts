import { Component, OnInit } from "@angular/core";

import { ProductService } from "../services/product-service";
import { Product } from "../models/product";

@Component({
    selector: 'store-product-list',
    templateUrl: './product-list.component.html'
})
export class ProductListComponent implements OnInit {
    products: Product[];

    constructor(private productService: ProductService) {}

    ngOnInit(): void {
        this.LoadProducts();
    }

    public LoadProducts(): void {
        this.productService.GetProducts().subscribe(
            products => {
                const prods : Product[] = [];
                products.forEach(p => prods.push(p));
                this.products = prods;
            }
        );
    }
}