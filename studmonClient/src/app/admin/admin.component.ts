import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Tanar } from '../_models/tanar';
import { studentModel } from '../_models/studentModel';
import { classModel } from '../_models/classModel';
import { TeremModel } from '../_models/teremModel';


@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent {
  http: HttpClient
  student: studentModel
  class: classModel 
  terem: TeremModel

  constructor(http: HttpClient) {
    this.http = http
    this.student = new studentModel()
    this.class = new classModel()
    this.terem = new TeremModel
  }

  public createStudent() : void{

    console.log(this.student)

    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    })
    this.http
      .post(
        'http://localhost:5231/HallgatoAPI',
        this.student,
        { headers: headers }
      )
      .subscribe(
        (success) => {
          console.log(success)
          this.student = new studentModel
        },
        (error) => {
          console.log(error)
        }
      )
  }

  public createClass() : void{

    console.log(this.class)

    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    })
    this.http
      .post(
        'http://localhost:5231/OraAPI',
        this.class,
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

  public createTerem() : void{
    console.log(this.terem)

    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    })
    this.http
      .post(
        'http://localhost:5231/TeremAPI',
        this.terem,
        { headers: headers }
      )
      .subscribe(
        (success) => {
          console.log(success)
          this.terem = new TeremModel
        },
        (error) => {
          console.log(error)
        }
      )

  }


}
