import { Component, OnInit } from '@angular/core';
import { studentModel } from '../_models/studentModel';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { classModel } from '../_models/classModel';
import { performanceModel } from '../_models/performanceModel';

@Component({
  selector: 'app-student-statistic',
  templateUrl: './student-statistic.component.html',
  styleUrls: ['./student-statistic.component.css']
})
export class StudentStatisticComponent implements OnInit {
  students: Array<studentModel>
  http: HttpClient
  foundStudent: boolean
  actualStudent: studentModel
  alkalmakSzama: Array<number>
  public searchForm !: FormGroup


  //student: studentModel ={neptunKod: "GQ814D", nev: "Nyári Dalma", kar: "NIK", kepzesNev: "Bsc", orak:[ ], teljesitmeny:[{performanceId: "sadas",studentId:"GQ814D", classId:"MAth.10", ertekeles: 1,weekNumber:1}]}


  constructor(http: HttpClient, private formBuilder: FormBuilder, private router: Router) {
    this.students = []
    this.http = http
    this.alkalmakSzama = []
    this.foundStudent = false
    this.actualStudent = new studentModel
    this.getAllStudent()
  }

  ngOnInit(): void {
    this.searchForm = this.formBuilder.group({
      findStudent: ['', Validators.required]
    })
  }


  private getAllStudent() {
    this.http.get<any>('http://localhost:5231/HallgatoAPI')
      .subscribe(resp => {
        //console.log(resp)
        resp.map((x: any) => {
          let s = new studentModel()
          s.neptunKod = x.neptunKod
          s.nev = x.nev
          s.kar = x.kar
          s.kepzesNev = x.kepzesNev
          s.kar = x.kar
          s.orak = x.orak
          s.teljesitmeny = x.teljesitmeny
          this.students.push(s)
        })
        //console.log(this.students)
      })
  }


  getClasses(found: studentModel) {
    this.http.get<any>('http://localhost:5231/HallgatoAPI/' + found.neptunKod)
      .subscribe((resp) => {
        this.actualStudent = resp
        let mentett = 0
        let oraMentesTomb = new Array<classModel>
        let performanceMentesTomb = new Array<performanceModel>
        resp.orak.map((x: any) => {
          if (x.ora.alkalmakSzama > mentett) {
            mentett = x.ora.alkalmakSzama
          }
          let oraMentes = new classModel
          oraMentes.Id = x.ora.id
          oraMentes.nev = x.ora.nev
          oraMentes.leiras = x.ora.leiras
          oraMentes.teremId = x.ora.teremID
          oraMentes.tanarId = x.ora.tanarID
          oraMentes.alkalmakSzama = x.ora.alkalmakSzama
          oraMentes.oraKezdet = x.ora.oraKezdet
          oraMentes.oraVeg = x.ora.oraVeg
          oraMentesTomb.push(oraMentes)
          //console.log(x)
        })
        resp.teljesitmeny.map((x: any) => {
          let perMentes = new performanceModel
          perMentes.teljesitmenyID = x.teljesitmenyID
          perMentes.classId = x.oraId
          perMentes.ertekeles = x.ertekeles
          perMentes.studentId = x.hallgatoNeptunKod
          perMentes.weekNumber = x.weekNumber
          performanceMentesTomb.push(perMentes)
        })
        this.alkalmakSzama = Array(mentett).fill(0)
        this.actualStudent.orak = oraMentesTomb
        this.actualStudent.teljesitmeny = performanceMentesTomb
        //console.log(this.actualStudent)
      })
  }

  searchMethod() {
    let split = this.searchForm.value.findStudent.replace("(", "")
    //console.log(this.searchForm.value.findStudent)
    split = split.replace(")", "")
    let datas = split.split(' ')
    //console.log(datas[2])
    let found = this.students.find(t => t.neptunKod === datas[datas.length - 1])
    if (found === undefined) {
      this.foundStudent = false
    } else {
      this.foundStudent = true
      this.getClasses(found)
      //console.log(this.actualStudent)
    }

  }
  teljesitmenyValaszto(oraModel: classModel, alkalom: number): string {
    let a = this.actualStudent.teljesitmeny.find(t => t.weekNumber === alkalom && oraModel.Id === t.classId)
    if (a !== undefined) {
      return a.ertekeles.toString()
    }
    else {
      return "-"
    }
  }

  teljesitmenySzamlalo(item: classModel): boolean {
    let osszes = this.actualStudent.teljesitmeny.filter(t => t.classId === item.Id).length
    let egyesek = this.actualStudent.teljesitmeny.filter(t => t.ertekeles === 1 && t.classId === item.Id).length
    let nullasok = this.actualStudent.teljesitmeny.filter(t => t.ertekeles === 0 && t.classId === item.Id).length
    if (egyesek === 0) {
      return false
    }
    else if (egyesek === 1) {
      if (osszes >= 14) {
        return false
      } else if (((nullasok + egyesek) / osszes * 100) >= 50) {
        return true
      }
    }
    else {
      if (((nullasok + egyesek) / osszes * 100) >= 50
        || (egyesek / osszes * 100) >= 60) {
        return true
      }
      else {
        return false
      }
    }

    return false
  }

  alkalomGenerator(alkalmakSzama: number): any {
    return Array(alkalmakSzama).fill(0)
  }
}
