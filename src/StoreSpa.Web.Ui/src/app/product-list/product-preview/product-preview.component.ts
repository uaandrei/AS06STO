import { Component, Input } from "@angular/core";

import { Product } from "../../models/product";

@Component({
    selector: 'store-product-preview',
    template: `
        <div class="col-md-3">
            <h2>{{product.id}}</h2>
            <p>{{product.name}}</p>
            <p><a class="btn btn-default" routerLink="/view/{{product.id}}" role="button">View details »</a></p>
        </div>
    `
})
export class ProductPreviewComponent {
    @Input() product: Product;
}