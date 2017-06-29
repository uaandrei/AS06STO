import { Component, Input } from "@angular/core";

import { Product } from "../../models/product";

@Component({
    selector: 'store-product-preview',
    templateUrl: './product-preview.component.html'
})
export class ProductPreviewComponent {
    @Input() product: Product;
}