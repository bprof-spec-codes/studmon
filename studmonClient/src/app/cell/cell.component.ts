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

  changeGrade(e:any) {
    let grade=e.target.value
    switch (grade) {
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
