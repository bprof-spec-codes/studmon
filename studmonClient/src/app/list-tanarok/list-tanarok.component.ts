import { Component } from '@angular/core';
import { TanarokService } from './tanarok.service';
import { take, tap } from 'rxjs';


@Component({
  selector: 'app-list-tanarok',
  templateUrl: './list-tanarok.component.html',
  styleUrls: ['./list-tanarok.component.css']
})
export class ListTanarokComponent {
  tanarok: any;
  tanarok$: any;

  constructor(private tanar: TanarokService) {

  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.tanarok$ = this.tanar
      .getData()
      .pipe(tap((data) => this.tanarok = data));
    console.log(this.tanarok$);
    console.log(this.tanarok);
  }



}
