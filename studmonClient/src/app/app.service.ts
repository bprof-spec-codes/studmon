import { HttpClient, HttpHeaders } from "@angular/common/http"
import { Injectable } from "@angular/core"
import { Router } from "@angular/router"
import { Observable } from "rxjs"
import { Tanar } from "./_models/tanar"

@Injectable({
  providedIn: 'root'
})

export class ApiService{
  router: Router
  http: HttpClient

  constructor(router: Router, http: HttpClient){
    this.router = router
    this.http = http
  }

  public isLoggedIn():boolean{
    let token = localStorage.getItem('studmon-token')
    return token !== null
  }

  public canActivate():boolean{
    if (!this.isLoggedIn()){
      this.router.navigate(['/'])
      return false
    }
    return true
  }

  siteUser(): Observable<any> {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer '+ localStorage.getItem('FrontendFF-token')
    })

    return this.http.get<Tanar>('http://localhost:5231/TanarAPI', { headers: headers })
  }

  //------ HÍVD MEG EZT, HA SZÜKSÉGED VAN A BEJELENTKEZETT FELHASZNÁLÓ ADATAIRA
  // localStorage-be eltárolja az NEPTUN-ját
  userInfo(callback: (success: any) => void, errorCallback: (error: any) => void): void {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + localStorage.getItem('studmon-token')
    });

    this.http.get<any>('http://localhost:5231/Auth', { headers: headers }).subscribe(
      (success) => {
        localStorage.setItem('neptun', success.neptunKod);
        localStorage.setItem('user-role', success.roles);
        callback(success);
      },
      (error) => {
        console.log(error);
        errorCallback(error);
      }
    );
  }
}
