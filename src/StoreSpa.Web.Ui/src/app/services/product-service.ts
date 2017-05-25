import { Injectable } from "@angular/core";
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { Product } from "../models/product";

@Injectable()
export class ProductService {
    apiGetUrl = "http://localhost:31252/api/product/";

    constructor(private http: Http) { }

    public GetProducts(): Promise<Product[]> {
        return this.http.get(this.apiGetUrl).toPromise()
                .then(
                    r => r.json() as Product[]
                )
                .catch((err) => { 
                    console.log(err); 
                });
    }

    public GetProduct(id: String) {
        return "";
    }

    public AddProduct(product: Product) {

    }
}