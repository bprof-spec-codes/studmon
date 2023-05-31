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
  @Input() class: any | undefined;
  @Input() studentList: studentModel[] | undefined;
  @Input() nk: String | undefined;
  @Input() coll: number =1
  @Input() rowIndex: number =1


  http: HttpClient
  student: any
  student2: any
  weekNumber: number

  grade: String ="neutral";
  // student: studentModel ={neptunKod: "", nev: "", kar: "", kepzesNev: "", orak:[ ], teljesitmeny:[]}
  gradeNumber: number = -100



  constructor(http: HttpClient, private route: ActivatedRoute) {
    this.http = http
    this.weekNumber = 0
    
  }


  private numbersCalc(){
    this.route.params.subscribe((params)=>{
  
      this.weekNumber =  params['alkalom']})
  }

  ngOnInit(): void {
    this.student2 = this.fetchData()
    
  }

  changeGrade(e:any) {
    //let grade=e.target.value
    //TODO nem működik a színváltás tíusát kinyomozni
    this.gradeNumber = parseInt(e.target.value,10)
    //console.log(this.gradeNumber);

    
    switch (this.gradeNumber) {
      case -1:
        this.grade = "negative"       
        break;
        case 0:
          this.grade="neutral"
        break;
        case 1:
          this.grade="positive"
        break;
      default:
        break;
    }
    // this.apiCall()
}

 private apiCall(){
  console.log("EZT NÉZZÜK BASZD MEG",this.student2)
  let oraId = ""
  this.route.params.subscribe((params)=>{
     oraId = params['id'];
     this.weekNumber = params['alkalom']})

  let newTeljesitmeny = {
  hallgatoNeptunKod: this.nk,
  oraId: oraId,
  ertekeles: this.gradeNumber,
  weekNumber: this.weekNumber  }
  console.log(newTeljesitmeny)
  this.http.post<any>(`http://localhost:5231/TeljesitmenyAPI/`, newTeljesitmeny, { responseType: 'json' })
      .subscribe(resp => {
        console.log(resp)
      })
 }


private fetchData(){
  this.numbersCalc()
  if(this.nk !== "@"){
     this.http.get<any>(`http://localhost:5231/HallgatoAPI/${this.nk}`, { responseType: 'json' })
      .subscribe(resp => {
        this.student = resp
          console.log("AlmásRétes",this.student)
          this.gradeNumber = this.student?.teljesitmeny[this.weekNumber-1]?.ertekeles || 0
          switch (this.gradeNumber) {
            case -1:
              this.grade = "negative"       
              break;
              case 0:
                this.grade="neutral"
              break;
              case 1:
                this.grade="positive"
              break;
            default:
              break;
          }
        })
  }
  return this.student
}

}
