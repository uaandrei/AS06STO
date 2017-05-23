import { Component, Input } from "@angular/core";

import { Product } from "../../models/product";

@Component({
    selector: 'store-product-preview',
    template: `
        <div class="col-md-3">
            <h2>{{product.name}}</h2>
            <span>{{product.price}}</span>RON
            <p><a class="btn btn-default" routerLink="/view/{{product.id}}" role="button">View details »</a></p>
        </div>
    `
})
export class ProductPreviewComponent {
    @Input() product: Product;
}