import { Component } from '@angular/core';
import { ApiService } from '../app.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent {
  api: ApiService

  constructor(api: ApiService) {
    this.api = api
    api.userInfo()
  }
}
