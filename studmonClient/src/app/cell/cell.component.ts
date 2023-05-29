import { Component, Input, Output } from '@angular/core';
import { studentModel } from '../_models/studentModel';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-cell',
  templateUrl: './cell.component.html',
  styleUrls: ['./cell.component.css']
})
export class CellComponent {

  @Input() name: String | undefined;
  @Input() type: Number | undefined;
  @Input() row: Number | undefined;
  @Input() studentList: studentModel[] | undefined;
  @Input() student: studentModel 
  http: HttpClient


  grade: String ="neutral";
  // student: studentModel ={neptunKod: "", nev: "", kar: "", kepzesNev: "", orak:[ ], teljesitmeny:[]}
  gradeNumber: string = "-100"



  constructor(http: HttpClient, private route: ActivatedRoute) {
    this.http = http
    this.student ={neptunKod: "", nev: "", kar: "", kepzesNev: "", orak:[ ], teljesitmeny:[]}
    
  }

  changeGrade(e:any) {
    //let grade=e.target.value
    this.gradeNumber = e.target.value
    switch (this.gradeNumber) {
      case "-1":
        this.grade = "negative"       
        break;
        case "0":
          this.grade="neutral"
        break;
        case "1":
          this.grade="positive"
        break;
      default:
        break;
    }
    console.log("Répa torta")
    //this.apiCall()
}

 private apiCall(){
  console.log("EZT NÉZZÜK BASZD MEG",this.student)
  let oraId = ""
  let weekNumber = 0
  this.route.params.subscribe((params)=>{
     oraId = params['id'];
     weekNumber = params['alkalom']})

  let newTeljesitmeny = {
  hallgatoNeptunKod: this.student!.neptunKod,
  oraId: oraId,
  ertekeles: this.gradeNumber,
  weekNumber: weekNumber  }
  console.log(newTeljesitmeny)
  this.http.post<any>(`http://localhost:5231/TeljesitmenyAPI/`, newTeljesitmeny, { responseType: 'json' })
      .subscribe(resp => {
        console.log(resp)
      })
 }


}
