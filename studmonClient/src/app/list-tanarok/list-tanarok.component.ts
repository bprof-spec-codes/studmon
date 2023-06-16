import { Component } from '@angular/core';
import { Tanar } from '../_models/tanar';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-list-tanarok',
  templateUrl: './list-tanarok.component.html',
  styleUrls: ['./list-tanarok.component.css']
})
export class ListTanarokComponent {
  tanarok: Array<Tanar>
  http: HttpClient

  constructor(http: HttpClient) {
    this.tanarok = []
    this.http = http
    this.getAllTeacher()
  }

  private getAllTeacher() {
    this.http.get<any>('http://localhost:5231/TanarAPI')
    .subscribe(resp=>{
      //console.log(resp)
      resp.map((x:any) => {
        let t = new Tanar()
        t.neptun = x.id
        t.nev = x.nev
        t.email = x.email
        this.tanarok.push(t)
      })
      //console.log(this.tanarok)
    })
  }
}
