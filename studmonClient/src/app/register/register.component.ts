import { FormBuilder, FormGroup } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['../login-form/login-form.component.css']
})
export class RegisterComponent implements OnInit{
  form: FormGroup | any;
  RegisterServiceService: any;

  constructor(private formBuilder: FormBuilder,
    private http: HttpClient,
    private router: Router) {


  }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      nev:'',
      email:'',
      id:'',
      passwordHash:''
    })
  }

  submit(): void{
    //console.log(this.form.getRawValue());
    this.http.post('http://localhost:5231/TanarAPI',JSON.stringify(this.form.getRawValue()))
    .subscribe(res=> {
        console.log(res);
        this.router.navigate(['/']);
      })

  }
}
