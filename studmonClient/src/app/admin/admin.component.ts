import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Tanar } from '../_models/tanar';
import { studentModel } from '../_models/studentModel';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})

export class AdminComponent {
  http: HttpClient
  teacher: Tanar
  student: studentModel

  constructor(http: HttpClient) {
    this.http = http
    this.teacher = new Tanar()
    this.student = new studentModel
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
      .subscribe(
        (success) => {
          console.log(success)
        },
        (error) => {
          console.log(error)
        }
      )
  }

  public createStudent() : void{

  }




}
