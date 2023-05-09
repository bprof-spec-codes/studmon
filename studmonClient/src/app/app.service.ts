import { Injectable } from "@angular/core"

@Injectable({
  providedIn: 'root'
})

export class ApiService{

  constructor() { }

  public isLoggedIn():boolean{
    let token = localStorage.getItem('studmon-token')
    return token !== null
  }
}
