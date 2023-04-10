import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class TanarokService {

  constructor(private http:HttpClient) { }

  getData(){
    //let url = "https://practiceapi.nikprog.hu/Student";
    let url = "http://localhost:5231/TanarAPI";
    return this.http.get(url);
  }
}
