import { RouterModule, Routes } from '@angular/router';

import { ProductViewComponent } from "../product-list/product-view/product-view.component";
import { ProductListComponent } from "../product-list/product-list.component";
import { StoreAppHomeComponent } from "../store-app-home.component";
import { ProductNewComponent } from "../product-list/product-new/product-new.component";
import { AuthGuard } from "../guards/auth-guard.service";

export const routes: Routes = [
    { path: '', redirectTo: '/home', pathMatch : "full"},
    { path: 'home', component: StoreAppHomeComponent },
    { path: 'list', component: ProductListComponent },
    { path: 'view/:id', component: ProductViewComponent },
    { path: 'new', component: ProductNewComponent, canActivate: [AuthGuard] }
];