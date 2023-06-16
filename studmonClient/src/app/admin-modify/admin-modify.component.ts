import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { TeremModel } from '../_models/teremModel';
import { Ora } from '../_models/oraModel';
import { studentModel } from '../_models/studentModel';
import { Router } from '@angular/router';
import { ApiService } from '../app.service';
import { Tanar } from '../_models/tanar';

@Component({
  selector: 'app-admin-modify',
  templateUrl: './admin-modify.component.html',
  styleUrls: ['./admin-modify.component.css']
})
export class AdminModifyComponent {

  http: HttpClient;
  subjects: Array<Ora>;
  classrooms: Array<TeremModel>;
  students: Array<studentModel>;
  router: Router;
  api: ApiService;
  selectedObject: string

  constructor(http: HttpClient, api: ApiService, router: Router) {
    this.http = http;
    this.subjects = [];
    this.classrooms = [];
    this.students = [];
    this.router = router;
    this.api = api;
    this.selectedObject = 'Hallgato';

  }

  ngOnInit(): void {
    this.http
      .get<Array<studentModel>>('http://localhost:5231/HallgatoAPI')
      .subscribe(resp => {
        resp.map(x => {
          let s = new studentModel();
          s.neptunKod = x.neptunKod;
          s.nev = x.nev;
          s.kar = x.kar;
          s.kepzesNev = x.kepzesNev;
          s.orak = x.orak;
          s.teljesitmeny = x.teljesitmeny;
          this.students.push(s);
        })
        console.log(this.students)
      })

    this.http
      .get<Array<TeremModel>>('http://localhost:5231/TeremAPI')
      .subscribe(resp => {
        resp.map(x => {
          let t = new TeremModel();
          t.nev = x.nev;
          t.elrendezes = x.elrendezes;
          t.orak = x.orak;
          this.classrooms.push(t);
        })
        console.log(this.classrooms)
      })

    this.http
      .get<Array<Ora>>('http://localhost:5231/OraAPI')
      .subscribe(resp => {
        console.log("RESP", resp)
        resp.map((x: any) => {
          let o = new Ora();
          o.id = x.id;
          o.nev = x.nev;
          o.leiras = x.leiras;
          o.teremNev = x.teremID;
          o.oraKezdet = x.oraKezdet;
          o.oraVeg = x.oraVeg;
          o.alkalmakSzama = x.alkalmakSzama;
          o.selectedAlkalom = x.selectedAlkalom;
          this.subjects.push(o);
        })
        console.log(this.subjects)
      })


  }

  public delete(tipus: string, id: string): void {
    const baseUrl = 'http://localhost:5231/';
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    })
    this.http
      .delete(
        `${baseUrl}${tipus}API/` + id,
        { headers: headers }
      )
      .subscribe(
        (success) => {
          //this.snackBar.open("Delete successful!", "Close", { duration: 5000 })
          console.log(success)
          let i
          switch (tipus) {
            case "Hallgato": {
              i = this.students.findIndex((t: any) => t.neptunKod === id);
              this.students.splice(i,1)
              break;
            }
            case "Ora": {
              i = this.subjects.findIndex((t: any) => t.id === id);
              this.subjects.splice(i,1)
              break;
            }
            case "Terem": {
              i = this.classrooms.findIndex((t: any) => t.nev === id);
              this.classrooms.splice(i,1)
              break;
            }
          }
          alert("Sikeres törlés!")
          /*this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
            this.router.navigate(['/admin-modify']);
          });*/
        },
        (error) => {
          console.log(error)
          //this.snackBar.open("Error occured, please try again.", "Close", { duration: 5000 })
        }
      )

  }

  public SelectObject(type: string) {
    this.selectedObject = type;
    console.log(this.selectedObject)
  }

  public DateToString(date: Date): string {
    const year = date.getFullYear().toString().padStart(4, '0');
    const month = (date.getMonth() + 1).toString().padStart(2, '0');
    const day = date.getDate().toString().padStart(2, '0');
    const hour = date.getHours().toString().padStart(2, '0');
    const minute = date.getMinutes().toString().padStart(2, '0');

    return `${year}/${month}/${day} ${hour}/${minute}`;
  }

}
