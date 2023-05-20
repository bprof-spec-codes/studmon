import { Component } from '@angular/core';
import { classModel } from '../_models/classModel';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-class-statistic',
  templateUrl: './class-statistic.component.html',
  styleUrls: ['./class-statistic.component.css']
})
export class ClassStatisticComponent {
  classes: Array<classModel>
  http: HttpClient

 
  class: classModel = { Id: "dasd", nev: "Anal1", leiras: "Matematikai analízis", teremId: "BA1.02", tanarId: "HSA234", alkalmakSzama: 5, oraKezdet: new Date(), oraVeg: new Date(), hallgatokColl: [], teljesitmenyColl: [], ulesRend: "H2123,B5642" }


  constructor(http: HttpClient) {
    this.classes = []
    this.http = http
    this.getAllClass()
  }


  private getAllClass() {
    this.http.get<any>('http://localhost:5231/OraAPI')
    .subscribe(resp=>{
      console.log(resp)
      resp.map((x:any) => {
        let c = new classModel()
        c.Id = x.Id
        c.nev = x.nev
        c.leiras= x.leiras
        c.teremId= x.teremId
        c.tanarId= x.tanarId
        c.alkalmakSzama= x.alkalmakSzama
        c.oraKezdet= x.oraKezdet
        c.oraVeg= x.oraVeg
        c.hallgatokColl = x.hallgatokColl
        c.teljesitmenyColl = x.teljesitmenyColl
        c.ulesRend = x.ulesRend
        this.classes.push(c)
      })
      console.log(this.classes)
    })
  }
}
