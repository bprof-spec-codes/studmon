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

  siteUser(): Observable<any> {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer '+ localStorage.getItem('FrontendFF-token')
    })

    return this.http.get<Tanar>('http://localhost:5231/TanarAPI', { headers: headers })
  }

  //------ HÍVD MEG EZT, HA SZÜKSÉGED VAN A BEJELENTKEZETT FELHASZNÁLÓ ADATAIRA
  // localStorage-be eltárolja az NEPTUN-ját
  userInfo(){
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer '+ localStorage.getItem('studmon-token')
    })

    this.http.get<any>('http://localhost:5231/Auth', { headers: headers })
    .subscribe(
      (success)=>{
        localStorage.setItem('neptun',success.neptunKod)
        localStorage.setItem('user-role',success.roles)
      },
      (error)=>{
        console.log(error)
      }
    )
  }
}
