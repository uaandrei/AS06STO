import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { StoreAppMainComponent } from "./store-app-main.component";


@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ StoreAppMainComponent ],
  bootstrap:    [ StoreAppMainComponent ]
})
export class AppModule { }
