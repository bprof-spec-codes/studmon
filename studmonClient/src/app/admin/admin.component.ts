import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Tanar } from '../_models/tanar';
import { studentModel } from '../_models/studentModel';
import { classModel } from '../_models/classModel';
import { TeremModel } from '../_models/teremModel';

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
  class: classModel;
  terem: TeremModel;
  classroomLayout: string = '';
  classroom: Checkbox[][] = [];
  rowcount: number = 7;
  coloumncount: number = 8;

  constructor(http: HttpClient) {
    this.http = http;
    this.student = new studentModel();
    this.class = new classModel();
    this.terem = new TeremModel();
    this.initializeClassroom();
  }

  initializeClassroom() {
    for (let i = 0; i < this.rowcount; i++) {
      const row: Checkbox[] = [];
      for (let j = 0; j < this.coloumncount; j++) {
        row.push({ checked: false });
      }
      this.classroom.push(row);
    }
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

    let layoutString = this.classroom.map(row => row.map(checkbox => (checkbox.checked ? '1' : '0')).join('')).join(',');

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


  
}
