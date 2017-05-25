import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from "@angular/router";
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { StoreAppMainComponent } from "./main/store-app-main.component";
import { StoreAppNavComponent } from "./nav/store-app-nav.component";
import { ProductListComponent } from "./product-list/product-list.component";
import { ProductService } from "./services/product-service";
import { ProductPreviewComponent } from "./product-list/product-preview/product-preview.component";
import { ProductViewComponent } from "./product-list/product-view/product-view.component";
import { routes } from "./routing/app.routing";
import { StoreAppHomeComponent } from "./store-app-home.component";
import { ProductNewComponent } from "./product-list/product-new/product-new.component";


@NgModule({
  imports:      [ BrowserModule, FormsModule, HttpModule, RouterModule.forRoot(routes) ],
  declarations: [ 
    StoreAppMainComponent, StoreAppNavComponent, StoreAppHomeComponent,
    ProductListComponent, ProductPreviewComponent, ProductViewComponent, ProductNewComponent
  ],
  bootstrap:    [ StoreAppMainComponent ],
  providers: [ ProductService ]
})
export class AppModule { }
