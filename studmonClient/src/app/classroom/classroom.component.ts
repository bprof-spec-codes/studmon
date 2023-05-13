import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.css']
})

export class ClassroomComponent {
  router: Router
  http: HttpClient
  rows: Array<any>
  studentList: Array<any>
  classRoomIdTest:string
  weekNumberTest:number
  @Input() classRoomId: String | undefined;
  @Input() weekNumber: Number | undefined; //alkalmakSzama

  constructor(http: HttpClient, router: Router) {
    this.studentList = []
    this.rows=[]
    this.classRoomIdTest="BA 1.21"
    this.http = http
    this.router = router
    this.weekNumberTest = 12
   
    this.getChairs()
    this.getStudents()

  }







  private getChairs() {
    this.http.get<any>(`http://localhost:5231/TeremAPI/${this.classRoomIdTest}`, {responseType:'json'})
    .subscribe(resp=>{
      const inputRows=resp.elrendezes.split(",")
      

      inputRows.map((x:any) => {
        
        let currentrow: { type:string }[]=[]
        x.split('').map((y:any) => {
          let currentCell={type:"0"}
          if(y==="1"){
            currentCell={type:"1"}
          }else{
            currentCell={type:"0"}    
             }
          currentrow.push(currentCell)
        })
        this.rows.push(currentrow)
      })
    })

    console.log(this.rows)
  }

  private getStudents(){
    this.http.get<any>(`http://localhost:5231/HallgatoApi`, {responseType:'json'})
    .subscribe(resp =>{
      console.log(resp)
      this.studentList=resp
    })
  }

}
