import { Component } from '@angular/core';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.css']
})

export class ClassroomComponent {
  rows=[[{name:"Pistike",isFull:true,isDesk:true},{name:"Pistike2",isFull:true,isDesk:true}],[{name:"",isFull:true,isDesk:false},{name:"Pistike4",isFull:true,isDesk:true}],[{name:"Pistike5",isFull:true,isDesk:true},{name:"",isFull:true,isDesk:false}]]
}
