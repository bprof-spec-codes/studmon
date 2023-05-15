import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Tanar } from '../_models/tanar';
@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})

export class AdminComponent {
  http: HttpClient
  teacher: Tanar

  constructor(http: HttpClient) {
    this.http = http
    this.teacher = new Tanar()
  }

  public createTeacher() : void {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    })
    this.http
      .post(
        'http://localhost:5231/TanarAPI',
        this.teacher,
        { headers: headers }
      )
  }

  


}
