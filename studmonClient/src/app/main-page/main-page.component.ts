import { Tanar } from './../_models/tanar';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { Ora } from '../_models/oraModel';
import { ApiService } from '../app.service';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent {
  userId = localStorage.getItem('neptun')
  http: HttpClient
  headers: HttpHeaders
  myClassesList: Array<Ora>
  me: Tanar

  constructor(http: HttpClient, private apiService: ApiService) {
    this.headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    })
    this.http = http
    this.myClassesList = []
    this.me = new Tanar()
    this.myDatas()
    this.myClasses()
  }
  myDatas() {
    this.apiService.siteUser()
      .subscribe((resp) => {
        let m = resp.find((t: any) => t.id === localStorage.getItem('neptun'))
        this.me.neptun = m.id
        this.me.nev = m.nev
        this.me.email = m.email
      })
  }

  //Kilistázza a belépett tanár óráit
  myClasses() {
    this.http.get<any>('http://localhost:5231/OraAPI', { headers: this.headers })
      .subscribe((success) => {
        success.map((t: any) => {
          if (t.tanarID === localStorage.getItem('neptun')) {
            let o = new Ora
            o.id = t.id
            o.nev = t.nev
            o.leiras = t.leiras
            o.teremNev = t.teremID
            o.oraKezdet = t.oraKezdet
            o.oraVeg = t.oraVeg
            o.alkalmakSzama = Array(t.alkalmakSzama).fill(0)
            o.selectedAlkalom = 1
            //console.log(t)
            this.myClassesList.push(o)
          }
        })
        //console.log(this.myClassesList)
      },
        (error) => {
          console.log(error)
        }
      )
  }

  alkalomValaszto(event: any, ora : Ora) {
    const selectedValue = event.target.value;
    ora.selectedAlkalom = selectedValue
    const index = this.myClassesList.findIndex(item => item.id === ora.id);
    this.myClassesList[index] = ora;
    //console.log(this.myClassesList);
  }

}
