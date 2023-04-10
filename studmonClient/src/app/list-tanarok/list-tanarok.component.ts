import { Component } from '@angular/core';
import { TanarokService } from './tanarok.service';


@Component({
  selector: 'app-list-tanarok',
  templateUrl: './list-tanarok.component.html',
  styleUrls: ['./list-tanarok.component.css']
})
export class ListTanarokComponent {
  constructor(private tanar:TanarokService){
    this.tanar.getData().subscribe(data=>{
      console.warn(data);
    })
  }
}
