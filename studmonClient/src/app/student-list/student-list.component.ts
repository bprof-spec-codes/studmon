import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { studentModel } from '../_models/studentModel';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnChanges {



  @Input() studentList: Array<studentModel> | undefined;
  @Input() student: studentModel = { neptunKod: "H4Z8BT", nev: "Sörös Bence", kar: "NIK", kepzesNev: "BSc", orak: [{}, {}], teljesitmeny: [{}, {}] }
  @Input() gradeNumber: string = "99"
  @Input() weekNumber: number = 12
  http: HttpClient


  constructor(http: HttpClient) {
    this.http = http

  }



  ngOnChanges(changes: SimpleChanges): void {
    let change = changes['gradeNumber']
    if (change?.currentValue && !change.isFirstChange()) {
      console.log(change.currentValue)
      this.student.teljesitmeny[this.weekNumber] = change.currentValue
      if(change?.currentValue != change.previousValue){
        console.log(this.student)
        this.http.put("http://localhost:5231/HallgatoAPI", this.student)
        .subscribe(
          (success) => {
            console.log(success)
          },
          (error) => {
            console.log(error)
          }
        )
      }
      
    }
  }

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

  changeValue(value: studentModel) {
    console.log(value)
    this.nev = value.nev
    this.student = value
    this.onCloseHandled()
  }


}
