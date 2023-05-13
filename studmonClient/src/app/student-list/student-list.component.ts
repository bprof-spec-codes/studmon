import { Component, EventEmitter, Input, Output } from '@angular/core';
import { studentModel } from '../_models/studentModel';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent {

  @Output() valueChange = new EventEmitter()
  @Input() studentList: Array<studentModel> | undefined;
  display = "none";
  nev:string = ""
  student: studentModel ={neptunKod: "H4Z8BT", nev: "Sörös Bence", kar: "NIK", kepzesNev: "BSc", orak:[{},{} ], teljesitmeny:[{},{}]}
  ngOnInit() {
   }
openModal() {
    this.display = "block";
  }
  onCloseHandled() {
    this.display = "none";
  }

changeValue(value: studentModel){
console.log(value)
  this.nev = value.nev
this.onCloseHandled()
}

  
}
