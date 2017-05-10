import { Component } from '@angular/core';

@Component({
  selector: 'store-app-home',
  template: `
    <div>{{Message}}</div>
  `
})
export class StoreAppHomeComponent  { 
    Message = 'Welcome!'; 
}
