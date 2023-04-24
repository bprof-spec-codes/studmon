import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginAuthServiceService {

  constructor(private http: HttpClient) { }

  login(email: string, password: string){
    //return this.http.post<any>('http://localhost:5231/Auth', {email, password}).shareReplay();
  }
}


