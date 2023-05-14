import { Component } from '@angular/core';
import { studentModel } from '../_models/studentModel';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-statistic',
  templateUrl: './student-statistic.component.html',
  styleUrls: ['./student-statistic.component.css']
})
export class StudentStatisticComponent {
  students: Array<studentModel>
  http: HttpClient

 
  student: studentModel ={neptunKod: "", nev: "", kar: "", kepzesNev: "", orak:[ ], teljesitmeny:[]}


  constructor(http: HttpClient) {
    this.students = []
    this.http = http
    this.getAllStudent()
  }


  private getAllStudent() {
    this.http.get<any>('http://localhost:5231/HallgatoAPI')
    .subscribe(resp=>{
      console.log(resp)
      resp.map((x:any) => {
        let s = new studentModel()
        s.neptunKod = x.id
        s.nev = x.nev
        s.kar= x.kar
        s.kepzesNev= x.kepzesNev
        s.kar= x.kar
        s.orak= x.orak
        s.teljesitmeny= x.teljesitmeny
        this.students.push(s)
      })
      console.log(this.students)
    })
  }
}
