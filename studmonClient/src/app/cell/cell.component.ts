import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-cell',
  templateUrl: './cell.component.html',
  styleUrls: ['./cell.component.css']
})
export class CellComponent {

  @Input() isDesk: Boolean | undefined;
  @Input() isFull: Boolean | undefined;
  @Input() name: String | undefined;

}
