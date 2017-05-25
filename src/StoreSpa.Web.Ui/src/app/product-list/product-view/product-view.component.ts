import { Component, Input, OnInit, OnDestroy } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Subscription } from "rxjs/Subscription";

import { Product } from "../../models/product";
import { ProductService } from "../../services/product-service";

@Component({
    selector: 'store-product-view',
    templateUrl: './product-view.component.html'
})
export class ProductViewComponent implements OnInit, OnDestroy {
    product: Product;
    productId: String;
    subscription: Subscription;

    constructor(
        private productService: ProductService,
        private route: ActivatedRoute) {}

    ngOnInit(): void {
        this.subscription = this.route.params.subscribe(
            (params: any) => {
                if(params.hasOwnProperty('id')) {
                    this.productId = params['id'];
                    //this.product = this.productService.GetProduct(this.productId);
                }
            }
        );
    }
        
    ngOnDestroy(): void {
        this.subscription.unsubscribe();
    }
}