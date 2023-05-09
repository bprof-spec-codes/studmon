import { Component } from '@angular/core';
import { ApiService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'studmonClient';
  api : ApiService

  constructor(api:ApiService) {
    this.api =api
  }
}
