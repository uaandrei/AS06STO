import { Component, OnInit } from "@angular/core";

import { ProductService } from "../services/product-service";
import { Product } from "../models/product";

@Component({
    selector: 'store-product-list',
    template: `
        <div class="col-md-9">
            <div class="row">
                <store-product-preview *ngFor="let product of products" [product]="product"></store-product-preview>
            </div>
        </div>
        <div class="col-md-3">
            <div class="list-group">
                <button type="button" class="list-group-item active">Cras justo odio</button>
                <button type="button" class="list-group-item">Dapibus ac facilisis in</button>
                <button type="button" class="list-group-item">Morbi leo risus</button>
                <button type="button" class="list-group-item">Porta ac consectetur ac</button>
                <button type="button" class="list-group-item">Vestibulum at eros</button>
            </div>
        </div>
    `
})
export class ProductListComponent implements OnInit {
    private products: Product[];

    constructor(private productService: ProductService) {}

    ngOnInit(): void {
        this.LoadProducts();
    }

    public LoadProducts(): void {
        this.products = this.productService.GetProducts();
    }
}