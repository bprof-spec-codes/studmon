import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { TeremModel } from '../_models/teremModel';
import { Ora } from '../_models/oraModel';
import { studentModel } from '../_models/studentModel';
import { Router } from '@angular/router';
import { ApiService } from '../app.service';

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

  constructor(http: HttpClient, api: ApiService, router: Router){
    this.http = http;
    this.subjects = [];
    this.classrooms =[];
    this.students =[];
    this.router = router;
    this.api = api;
  }
}
