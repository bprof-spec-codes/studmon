import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { RegisterModel } from '../_models/registerModel';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['../login-form/login-form.component.css']
})
export class RegisterComponent{
  router: Router
  http: HttpClient
  form: FormControl
  registerModel: RegisterModel

  constructor(http: HttpClient, router: Router) {
    this.http = http
    this.router = router
    this.registerModel = new RegisterModel()
    this.form = new FormControl('', [Validators.required, Validators.email])

  }

  ngOnInit(): void {

  }


  public sendRegister() : void{
    this.http.put('http://localhost:5231/Auth', this.registerModel)
    .subscribe(
      (success)=>{
        alert("Sikeres regisztráció!")
        this.router.navigate(["/"])
      },
      (error)=>{
        alert("Sikertelen regisztráció! :(")
      }
    )
  }

}
