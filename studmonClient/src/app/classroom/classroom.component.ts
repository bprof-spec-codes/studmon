import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
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
  alkalmakSzamaTomb: Array<number> = []
  class: any;
  notSittedStudents: Array<any>
  ulesRend: Array<string>


  constructor(http: HttpClient, router: Router, private route: ActivatedRoute) {
    this.studentList = []
    this.rows = []
    this.http = http
    this.router = router
    this.nameList = []
    this.notSittedStudents = []
    this.ulesRend = []
  }

  ngOnInit(): void {
    this.apiCall()
  }

  anotherWeek(het:number){
    this.studentList = []
    this.rows = []
    this.nameList = []
    this.notSittedStudents = []
    this.ulesRend = []
    this.router.navigate(["/classroom/"+this.oraId+"/"+het])
  }

  async apiCall() {
    await this.route.params.subscribe(params => {
      this.oraId = params['id'];
      this.weekNumber = params['alkalom'];
      //console.log(this.classRoomId)
      this.http.get<any>(`http://localhost:5231/OraAPI/${this.oraId}`, { responseType: 'json' })
        .subscribe(resp => {
          //console.log(resp)
          this.classRoomId = resp.terem.nev
          this.class = resp
          this.alkalmakSzamaTomb =  Array(resp.alkalmakSzama).fill(0)
          this.getChairs(resp)
          this.getStudents(resp)
          this.notSittedStudentsMethod()
        })
    })

  }

  private getChairs(resp: any) {
    const inputRows = resp?.terem.elrendezes.split(",")
    this.ulesRend = resp.ulesRend.split(" ")

    let index = 0
    inputRows.map((x: any) => {
      let currentrow: { type: string }[] = []
      x.split('').map((y: any) => {
        let currentCell = { type: "0", nk: this.ulesRend[index] }
        if (y === "1") {
          currentCell = { type: "1", nk: this.ulesRend[index] }
        } else {
          currentCell = { type: "0", nk: this.ulesRend[index] }
        }
        currentrow.push(currentCell)
        ++index
      })
      this.rows.push(currentrow)

    })
    // ulesRend.map((y: any, index : any) => {
    //   this.rows[index]={...this.rows[index], nk: y}
    // })
    //console.log("ROWS", this.rows)

  }

  private getStudents(resp: any) {
    this.studentList = resp.hallgatokColl.map((e: any) => e.hallgato)
    //console.log("STUDENTLIST", this.studentList);
  }

  private notSittedStudentsMethod() {
    this.studentList.forEach(element => {
      if (!this.ulesRend.includes(element.neptunKod)) {
        this.notSittedStudents.push(element)
      }
    });
  }

  getExactStudent(neptunKod: string): string {
    return this.studentList.find((t: any) => t.neptunKod === neptunKod).nev;
  }

  public isEqualWithRadioButton(value: number, studentNeptun: string): boolean {
    const stud = this.studentList.find((t: any) => t.neptunKod === studentNeptun)
    //console.log("STUD", stud)
    //debugger
    if (stud === undefined) {
      return false
    }
    const findTeljesitmeny = stud.teljesitmeny.find((t: any) => (t.oraId == this.oraId && t.weekNumber == this.weekNumber))
    //console.log("TELJESITMENY",findTeljesitmeny)
    if (findTeljesitmeny === undefined) {
      if (value === -1)
        return true
      else
        return false
    }
    else if (value === findTeljesitmeny.ertekeles) {
      return true
    }
    return false
  }

  radioChange(event: any, neptun: string) {
    //console.log(event.target.value, neptun)
    const stud = this.studentList.find((t: any) => t.neptunKod === neptun)
    const teljesitmenyId = stud.teljesitmeny.find((t: any) => (t.oraId == this.oraId && t.weekNumber == this.weekNumber)).teljesitmenyID
    //console.log(teljesitmenyId)
    const teljesitmeny = {
      teljesitmenyID: teljesitmenyId,
      hallgatoNeptunKod: neptun,
      oraId: this.oraId,
      ertekeles: event.target.value,
      weekNumber: this.weekNumber
    }
    //console.log(JSON.stringify(teljesitmeny))
    this.http.put<any>('http://localhost:5231/TeljesitmenyAPI', teljesitmeny)
      .subscribe((resp) => {
        this.studentList.find((t: any) => t.neptunKod === neptun).teljesitmeny.find((t: any) => t.teljesitmenyID === teljesitmenyId).ertekeles = Number(event.target.value)
        //console.log(this.studentList.find((t:any)=>t.neptunKod===neptun).teljesitmeny.find((t:any)=>t.teljesitmenyID===teljesitmenyId))
        //console.log(resp)
      })
  }

  //HALLGATÓ LEÜLTETÉSE
  hallgatoUltetes(event: any, oneRow: any, onePlace: any) {
    //console.log("event", event.target.value)
    //console.log("ROW", oneRow)
    //console.log("PLACE", onePlace)
    this.rows[oneRow][onePlace].nk = event.target.value
    let ultetes = ""
    this.rows.forEach(element => {
      element.forEach((item: any) => {
        ultetes += item.nk + " "
      });
    });
    ultetes.trim()
    //console.log(this.notSittedStudents)
    let index = this.notSittedStudents.findIndex((t: any) => t.neptunKod === event.target.value)
    this.notSittedStudents.splice(index, 1)
    this.updateSitting(ultetes)
  }

  removeStudentFromPlace(neptun: string, oneRow: any, onePlace: any) {
    this.rows[oneRow][onePlace].nk = "@"
    let ultetes = ""
    this.rows.forEach(element => {
      element.forEach((item: any) => {
        ultetes += item.nk + " "
      });
    });
    ultetes.trim()
    let student = this.studentList.find((t: any) => t.neptunKod === neptun)
    //console.log(student)
    this.notSittedStudents.push(student)
    this.updateSitting(ultetes)
  }

  async updateSitting(ultetes: string) {
    await this.http.get<any>(`http://localhost:5231/OraAPI/${this.oraId}`, { responseType: 'json' })
      .subscribe(resp => {
        //console.log(resp)
        resp.ulesRend = ultetes
        //console.log(JSON.stringify(resp))
        const returnData = {
          id: resp.id,
          nev: resp.nev,
          leiras: resp.leiras,
          teremID: resp.teremID,
          tanarID: resp.tanarID,
          alkalmakSzama: resp.alkalmakSzama,
          oraKezdet: resp.oraKezdet,
          oraVeg: resp.oraVeg,
          ulesRend: resp.ulesRend,
        }
        this.http.put<any>('http://localhost:5231/OraApi', returnData)
          .subscribe((t) => {
            //console.log(returnData)
          })
      })
  }


}
