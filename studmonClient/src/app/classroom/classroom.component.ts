import { Component, ElementRef, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.css']
})

export class ClassroomComponent implements OnInit {
  router: Router
  http: HttpClient
  rows: Array<any>
  studentList: Array<any>
  nameList: Array<string>
  classRoomId: string | undefined;
  oraId: string | undefined;
  weekNumber: number | undefined; //alkalmakSzama
  class: any


  constructor(http: HttpClient, router: Router, private route: ActivatedRoute) {
    this.studentList = []
    this.rows = []
    this.http = http
    this.router = router
    this.nameList = []
  }

  ngOnInit(): void {
    this.apiCall()
    console.log(this.studentList);
    
  }




  async apiCall() {
    await this.route.params.subscribe(params=>{
      this.oraId = params['id'];
      this.weekNumber = params['alkalom'];
      //console.log(this.classRoomId)
      this.http.get<any>(`http://localhost:5231/OraAPI/${this.oraId}`, { responseType: 'json' })
      .subscribe(resp => {
        //console.log(resp)
        this.classRoomId = resp.terem.nev
        this.class = resp
        this.getChairs(resp)
        this.getStudents(resp)
        })
    })
    
  }


  private getChairs(resp: any) {

      
          const inputRows = resp?.terem.elrendezes.split(",")
          const ulesRend = resp.ulesRend.split(" ")
        
            let index = 0
            inputRows.map((x: any) => {
              let currentrow: { type: string }[] = []
              x.split('').map((y: any) => {
                let currentCell = { type: "0", nk: ulesRend[index]}
                if (y === "1") {
                  currentCell = { type: "1", nk: ulesRend[index]}
                  index++
                } else {
                  currentCell = { type: "0", nk: ulesRend[index]}
                }
                currentrow.push(currentCell)
              })
              this.rows.push(currentrow)
            
            })    
            // ulesRend.map((y: any, index : any) => {
            //   this.rows[index]={...this.rows[index], nk: y}
            // })  
            console.log(this.rows)
            
  }

  private getStudents(resp: any) {
        this.studentList = resp.hallgatokColl.map((e:any) => e.hallgato)
  }

  

}
