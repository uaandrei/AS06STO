import { Injectable } from "@angular/core";
import { Http, Headers } from '@angular/http';


import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { Product } from "../models/product";

@Injectable()
export class ProductService {
    apiUrl = "http://localhost:34809/api/products/";

    constructor(private http: Http) { }

    public GetProducts(): Observable<Product[]> {
        return this.http.get(this.apiUrl).map(
            r => r.json() as Product[]
        );
    }

    public GetProduct(id: String): Observable<Product> {
        return this.http.get(this.apiUrl + id).map(r => r.json() as Product);
    }

    public AddProduct(product: Product): void {
        const headers = new Headers({ 'content-type': 'application/json' });
        this.http.post(this.apiUrl, JSON.stringify(product), { headers: headers }).toPromise();
    }
}