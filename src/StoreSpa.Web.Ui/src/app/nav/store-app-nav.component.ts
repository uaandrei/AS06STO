import { Component } from '@angular/core';
import { AuthService } from "../services/auth.service";

@Component({
  selector: 'store-app-nav',
  templateUrl: './store-app-nav.component.html'
})
export class StoreAppNavComponent  { 
    constructor(private authService: AuthService) {}
    
    isLoggedIn(): boolean {
        return this.authService.isLoggedIn;
    }

    login(): void {
        this.authService.login().subscribe(() => {
            let auth = this.authService.isLoggedIn;
        });
    }

    logout(): void {
        this.authService.logout();
    }
}
