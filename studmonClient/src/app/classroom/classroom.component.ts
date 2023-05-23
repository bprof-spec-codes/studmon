import { Component, Input, OnInit } from '@angular/core';
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
  classRoomIdTest: string
  weekNumberTest: number
  classRoomId: string | undefined;
  oraId: string | undefined;
  weekNumber: number | undefined; //alkalmakSzama


  constructor(http: HttpClient, router: Router, private route: ActivatedRoute) {
    this.studentList = []
    this.rows = []
    this.classRoomIdTest = "BA 1.21"
    this.http = http
    this.router = router
    this.weekNumberTest = 12

  }

  ngOnInit(): void {
    this.getOra()
  }




  async getOra() {
    await this.route.params.subscribe(params=>{
      this.oraId = params['id'];
      this.weekNumber = params['alkalom'];
      //console.log(this.classRoomId)
      this.http.get<any>(`http://localhost:5231/OraAPI/${this.oraId}`, { responseType: 'json' })
      .subscribe(resp => {
        //console.log(resp)
        this.classRoomId = resp.terem.nev

        this.getChairs()
        this.getStudents()
        })
    })
  }


  private getChairs() {
      this.http.get<any>(`http://localhost:5231/TeremAPI/${this.classRoomId}`, { responseType: 'json' })
        .subscribe(resp => {
          console.log(resp)
          const inputRows = resp.elrendezes.split(",")

          inputRows.map((x: any) => {
            let currentrow: { type: string }[] = []
            x.split('').map((y: any) => {
              let currentCell = { type: "0" }
              if (y === "1") {
                currentCell = { type: "1" }
              } else {
                currentCell = { type: "0" }
              }
              currentrow.push(currentCell)
            })
            this.rows.push(currentrow)
          })
        })

    console.log(this.rows)
  }

  private getStudents() {
    this.http.get<any>(`http://localhost:5231/HallgatoApi`, { responseType: 'json' })
      .subscribe(resp => {
        console.log(resp)
        this.studentList = resp
      })
  }

}
