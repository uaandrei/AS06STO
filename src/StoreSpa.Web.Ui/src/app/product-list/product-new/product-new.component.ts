import { Component, Input, OnInit } from "@angular/core";
import { Router } from "@angular/router";

import { Product } from "../../models/product";
import { ProductService } from "../../services/product-service";

@Component({
    selector: 'store-product-new',
    templateUrl: './product-new.component.html'
})
export class ProductNewComponent implements OnInit {
    newProductModel: Product;

    constructor(
        private productService: ProductService,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.newProductModel = new Product("", 0.00, "");
    }

    onAdd(product: Product) {
        var newProduct = new Product(product.Name, product.Price, product.Description);
        this.productService.AddProduct(newProduct);
        this.router.navigate(["/list"])
    }
}