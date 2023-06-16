import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from '../_models/loginModel';
import { TokenModel } from '../_models/tokenModel';
import { ApiService } from '../app.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent {
  router: Router
  http: HttpClient
  form: FormControl
  loginModel: LoginModel

  constructor(http: HttpClient, router: Router, private api: ApiService) {
    this.http = http
    this.router = router
    this.loginModel = new LoginModel()
    this.form = new FormControl('', [Validators.required, Validators.email])
  }

  public loginSend(): void {
    this.http.post<TokenModel>("http://localhost:5231/Auth", this.loginModel).subscribe(
      (success) => {
        localStorage.setItem('studmon-token', success.token);
        localStorage.setItem('studmon-token-expiration', success.expiration.toString());
        //console.log(success);
        this.api.userInfo(
          () => {
            this.router.navigate(['/mainpage']);
          },
          (error) => {
            //console.log(error);
          }
          );
        },
        (error) => {
        alert("Hibás jelszó vagy felhasználónév!")
        //console.log(error);
      }
    );
  }
}
