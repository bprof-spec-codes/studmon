import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { classModel } from '../_models/classModel';
import { HttpClient } from '@angular/common/http';
import { performanceModel } from '../_models/performanceModel';

@Component({
  selector: 'app-class-list',
  templateUrl: './class-list.component.html',
  styleUrls: ['./class-list.component.css']
})
export class ClassListComponent  {
  @Input() classList: Array<classModel> | undefined;
  @Input() class: classModel = { Id: "dasd", nev: "Anal1", leiras: "Matematikai analízis", teremId: "BA1.02", tanarId: "HSA234", alkalmakSzama: 5, oraKezdet: new Date(), oraVeg: new Date(), hallgatokColl: [], teljesitmenyColl: [], ulesRend: "H2123,B5642" }
  http: HttpClient


  constructor(http: HttpClient) {
    this.http = http

  }



  // ngOnChanges(changes: SimpleChanges): void {
  //   let change = changes['gradeNumber']
  //   if (change?.currentValue && !change.isFirstChange()) {
  //     console.log(change.currentValue)
  //     this.class.teljesitmeny[this.weekNumber] = change.currentValue
  //     if(change?.currentValue != change.previousValue){
  //       console.log(this.class)
  //       this.http.put("http://localhost:5231/HallgatoAPI", this.class)
  //       .subscribe(
  //         (success) => {
  //           console.log(success)
  //         },
  //         (error) => {
  //           console.log(error)
  //         }
  //       )
  //     }
      
  //   }
  // }

  private _display = "none";
  public get display() {
    return this._display;
  }
  public set display(value) {
    this._display = value;
  }
  nev: string = ""

  ngOnInit() {
  }
  openModal() {
    this.display = "block";
  }
  onCloseHandled() {
    this.display = "none";
  }

  changeValue(value: classModel) {
    console.log(value)
    this.nev = value.nev
    this.class = value
    this.onCloseHandled()
  }

}
