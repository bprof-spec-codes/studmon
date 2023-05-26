import { studentModel } from './../_models/studentModel';
import { AfterViewInit, Component } from '@angular/core';
import { classModel } from '../_models/classModel';
import { HttpClient } from '@angular/common/http';
import { performanceModel } from '../_models/performanceModel';

@Component({
  selector: 'app-class-statistic',
  templateUrl: './class-statistic.component.html',
  styleUrls: ['./class-statistic.component.css']
})
export class ClassStatisticComponent {
  classes: Array<classModel>
  http: HttpClient
  isSelectedOra: boolean
  allHallgato: Array<studentModel>
  alkalmakSzama: any
  selectedTargy: any | undefined

  //class: classModel = { Id: "dasd", nev: "Anal1", leiras: "Matematikai analízis", teremId: "BA1.02", tanarId: "HSA234", alkalmakSzama: 5, oraKezdet: new Date(), oraVeg: new Date(), hallgatokColl: [], teljesitmenyColl: [], ulesRend: "H2123,B5642" }


  constructor(http: HttpClient) {
    this.classes = []
    this.allHallgato = []
    this.http = http
    this.isSelectedOra = false
    this.getAllClass()
  }

  private getAllClass() {
    this.http.get<any>('http://localhost:5231/OraAPI')
      .subscribe(resp => {
        console.log(resp)
        resp.map((x: any) => {
          if (x.tanarID === localStorage.getItem('neptun')) {
            let c = new classModel()
            c.Id = x.id
            c.nev = x.nev
            c.leiras = x.leiras
            c.teremId = x.teremID
            c.tanarId = x.tanarID
            c.alkalmakSzama = x.alkalmakSzama
            c.oraKezdet = x.oraKezdet
            c.oraVeg = x.oraVeg
            c.hallgatokColl = x.hallgatokColl
            c.teljesitmenyColl = x.teljesitmenyColl
            c.ulesRend = x.ulesRend
            this.classes.push(c)
          }
        })
        console.log(this.classes)
      })
  }

  targyAdatok(selectedValue: string) {
    this.http.get<any>('http://localhost:5231/OraAPI/' + selectedValue)
      .subscribe(resp => {
        this.allHallgato = new Array<studentModel>
        this.alkalmakSzama = Array(resp.alkalmakSzama).fill(0)
        console.log("ADAT", resp)

        resp.hallgatokColl.map((x: any) => {
          let s = new studentModel
          console.log('HHHH', x)
          s.nev = x.hallgato.nev
          s.neptunKod = x.hallgato.neptunKod
          s.kar = x.hallgato.kar
          s.kepzesNev = x.hallgato.kepzesNev
          x.hallgato.teljesitmeny.map((telj: any) => {
            let k = new performanceModel
            k.performanceId = telj.teljesitmenyID
            k.classId = telj.oraId
            k.studentId = telj.hallgatoNeptunKod
            k.rating = telj.ertekeles
            k.weekNumber = telj.weekNumber
            s.teljesitmeny.push(k)
          })
          console.log(s)
          this.allHallgato.push(s)
        })
        console.log(this.allHallgato)
      })
  }

  targyValaszto(event: any) {
    this.selectedTargy = event.target.value;
    this.isSelectedOra = true
    this.targyAdatok(this.selectedTargy)
  }

  teljesitmenyValaszto(hallgato: studentModel, alkalom: number): string {
    let a = hallgato.teljesitmeny.find(t => t.weekNumber === alkalom && t.classId === this.selectedTargy)
    if (a !== undefined) {
      //console.log(hallgato)
      //console.log(this.selectedTargy)
      return a.rating.toString()
    }
    else {
      return ""
    }
  }

  teljesitmenySzamlalo(item: studentModel): boolean {
    let osszes = item.teljesitmeny.length
    let egyesek = item.teljesitmeny.filter(t => t.rating === 1).length
    let nullasok = item.teljesitmeny.filter(t => t.rating === 0).length
    if (egyesek === 0) {
      return false
    }
    else if (egyesek === 1) {
      if (osszes >= 14) {
        return false
      } else if ((nullasok / osszes * 100) >= 50) {
        return true
      }
    }
    else {
      if ((nullasok / osszes * 100) >= 50
        || (egyesek / osszes * 100) >= 60) {
        return true
      }
      else {
        return false
      }
    }

    return false
  }
}
