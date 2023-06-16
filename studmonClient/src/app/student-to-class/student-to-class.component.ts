import { HttpClient } from '@angular/common/http';
import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { studentModel } from '../_models/studentModel';
import { findIndex } from 'rxjs';

@Component({
  selector: 'app-student-to-class',
  templateUrl: './student-to-class.component.html',
  styleUrls: ['./student-to-class.component.css']
})
export class StudentToClassComponent implements OnInit {
  router: Router
  http: HttpClient
  oraId: string | undefined;
  unsubscribedStudents: Array<studentModel>
  subscribedStudents: Array<studentModel>
  addableStudents: Array<studentModel>

  constructor(http: HttpClient, router: Router, private route: ActivatedRoute) {
    this.http = http
    this.router = router
    this.unsubscribedStudents = []
    this.subscribedStudents = []
    this.addableStudents = new Array<studentModel>
  }
  ngOnInit(): void {
    this.getUnSubscribedStudents()
  }

  //MEGMONDJA KIK VANNAK FELIRATKOZTATVA AZ ÓRÁRA ÉS KIK NEM
  async getUnSubscribedStudents() {
    await this.route.params.subscribe(params => {
      this.oraId = params['id']
      //console.log(this.oraId)

      this.http.get<any>('http://localhost:5231/HallgatoAPI')
        .subscribe(resp => {
          //console.log(resp)
          resp.map((t: any) => {
            let uss = new studentModel
            uss.nev = t.nev
            uss.neptunKod = t.neptunKod
            uss.kar = t.kar
            uss.kepzesNev = t.kepzesNev
            uss.orak = t.orak
            let oraKereses = t.orak.find((t: any) => t.oraId === this.oraId)
            if (oraKereses === undefined) {
              this.unsubscribedStudents.push(uss)
            } else {
              this.subscribedStudents.push(uss)
            }
          })
          //console.log("NEM FELIRATKOZOTTAK", this.unsubscribedStudents)
          //console.log("FELIRATKOZOTTAK", this.subscribedStudents)
        })
    })

  }

  checkboxClicked(event: any, item: studentModel) {
    let benneVan = this.addableStudents.findIndex((t: any) => t.neptunKod === item.neptunKod)
    if (benneVan === -1) {//ha nincs benne akkor beleteszem
      this.addableStudents.push(item)
    } else {//ha benne van, kiveszem
      this.addableStudents.splice(benneVan, 1)
    }
  }

  async addStudentsForm() {
    //console.log(this.addableStudents)
    await this.addableStudents.forEach(t => {
      let saveTo: any =
      {
        oraId: this.oraId,
        hallgatoId: t.neptunKod
      }

      //console.log(JSON.stringify(saveTo))
      this.http.post<any>('http://localhost:5231/OMToHMAPI', saveTo)
        .subscribe((resp) => {
          this.addableStudents = []
          let i = this.unsubscribedStudents.findIndex((k: any) => k.neptunKod === t.neptunKod)
          this.unsubscribedStudents.splice(i, 1)
          this.subscribedStudents.push(t)
        })
    })
  }

  //Hallgató törlése az óráról
  async removeStudent(item: studentModel) {
    //console.log(item)
    await this.http.get<any>('http://localhost:5231/OMToHMAPI')
      .subscribe((resp) => {
        let keresettKapcsolat = resp.find((t: any) => t.hallgatoId === item.neptunKod && t.oraId === this.oraId)
        this.http.delete<any>('http://localhost:5231/OMToHMAPI/' + keresettKapcsolat.id)
          .subscribe((resp) => {
            this.unsubscribedStudents.push(item)
            let index = this.subscribedStudents.findIndex((t: any) => t.neptunKod === item.neptunKod)
            this.subscribedStudents.splice(index, 1)

            //ÜLÉSREND
            this.http.get<any>(`http://localhost:5231/OraAPI/${this.oraId}`, { responseType: 'json' })
              .subscribe(resp => {
                //debugger
                //console.log(resp.ulesRend)
                resp.ulesRend = resp.ulesRend.replace(item.neptunKod, '@')
                //console.log(resp.ulesRend)
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
          })

      })
    //this.http.delete<any>('')
  }

}
