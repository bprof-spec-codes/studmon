import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Tanar } from '../_models/tanar';
import { studentModel } from '../_models/studentModel';
import { classModel } from '../_models/classModel';
import { TeremModel } from '../_models/teremModel';
import { OraCreate } from '../_models/oraModel';

interface Checkbox {
  checked: boolean;
}

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent {
  http: HttpClient;
  student: studentModel;
  students: Array<studentModel> = []
  teachers: Array<Tanar> = []
  class: OraCreate;
  terem: TeremModel;
  classroomLayout: string = '';
  classroom: Checkbox[][] = [];
  rowcount: number = 1;
  coloumncount: number = 1;
  termek: Array<TeremModel>
  selectedObject: string = 'Hallgato'

  constructor(http: HttpClient) {
    this.http = http;
    this.student = new studentModel();
    this.class = new OraCreate();
    this.terem = new TeremModel();
    this.termek =[]
    this.initializeClassroom();
  }

  ngOnInit() : void{
    this.http.get<any>('http://localhost:5231/TeremAPI')
    .subscribe((resp)=>{
      resp.map((t:any)=>{
        let ter = new TeremModel
        ter.nev = t.nev
        ter.elrendezes = t.elrendezes
        console.log(ter)
        this.termek.push(ter)
      })}
    )

    this.http.get<any>('http://localhost:5231/TanarAPI')
    .subscribe((resp)=>{
      resp.map((t:any)=>{
        let tanar = new Tanar;
        tanar.neptun = t.neptun
        tanar.nev = t.nev
        tanar.email = t.email
        this.teachers.push(tanar)
      })
      console.log(this.teachers)
    }

    )
  }

  initializeClassroom() {
    this.classroom = []
    for (let i = 0; i < this.rowcount; i++) {
      const row: Checkbox[] = [];
      for (let j = 0; j < this.coloumncount; j++) {
        row.push({ checked: false });
      }
      this.classroom.push(row);
    }
  }

  rowcountChange(value:any){
    this.rowcount = value.target.value
    this.initializeClassroom()
  }

  columncountChange(value:any){
    this.coloumncount = value.target.value
    this.initializeClassroom()
  }



  public createStudent(): void {
    console.log(this.student);

    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    });

    this.http
      .post('http://localhost:5231/HallgatoAPI', this.student, { headers: headers })
      .subscribe(
        (success) => {
          console.log(success);
          this.student = new studentModel();
        },
        (error) => {
          console.log(error);
        }
        );
      }

      public createTerem(): void {
        console.log(this.terem);


        console.log(this.classroom)

        let layoutString = this.classroom.map(row => row.map(checkbox => (checkbox.checked ? '0' : '1')).join('')).join(',');

        this.terem.elrendezes = layoutString;

        let headers = new HttpHeaders({
          'Content-Type': 'application/json',
          'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
        });

        this.http
        .post('http://localhost:5231/TeremAPI', this.terem, { headers: headers })
        .subscribe(
          (success) => {
            console.log(success);
            console.log(this.terem);
            alert("Sikeres terem létrehozás!")
          },
          (error) => {
            console.log(error);
          }
          );
        }

  public createClass() : void{

    this.class.tanarId = 'DFG234'
    console.log(this.class)
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    });
    this.http
      .post('http://localhost:5231/OraAPI', this.class, { headers: headers })
      .subscribe(
        (success) => {
          console.log(success);
          console.log(this.class);
        },
        (error) => {
          console.log(error);
        }
        );
      }

      // isTeremValid() {
        //   return this.terem.nev !== '' && this.terem.elrendezes !== '';
        // }

  isHallgatoValid() {
    return (
      this.student.nev !== '' &&
      this.student.neptunKod &&
      this.student.neptunKod.length === 6 &&
      !/\s/.test(this.student.neptunKod)
      );
    }

    public SelectObject(type: string){
      this.selectedObject = type;
      console.log(this.selectedObject)
    }

    isTeremValid(){
      return this.terem.nev === ''
    }

    isOraValid(){
      return this.class.nev !=''
    }


}
