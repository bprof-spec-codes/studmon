import { Component, Input, Output } from '@angular/core';
import { studentModel } from '../_models/studentModel';

@Component({
  selector: 'app-cell',
  templateUrl: './cell.component.html',
  styleUrls: ['./cell.component.css']
})
export class CellComponent {

  @Input() name: String | undefined;
  @Input() type: Number | undefined;
  @Input() row: Number | undefined;
  @Input() studentList: studentModel[] | undefined;


  grade: String ="neutral";
  student: studentModel ={neptunKod: "", nev: "", kar: "", kepzesNev: "", orak:[ ], teljesitmeny:[]}
  gradeNumber: string = "0"

  changeGrade(e:any) {
    //let grade=e.target.value
    this.gradeNumber = e.target.value
    switch (this.gradeNumber) {
      case "-1":
        this.grade = "negative"       
        break;
        case "0":
          this.grade="neutral"
        break;
        case "1":
          this.grade="positive"
        break;
      default:
        break;
    }
}


}
