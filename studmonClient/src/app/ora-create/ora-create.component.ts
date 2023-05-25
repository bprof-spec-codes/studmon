import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { OraCreate } from '../_models/oraModel';
import { TeremModel } from '../_models/teremModel';

@Component({
  selector: 'app-ora-create',
  templateUrl: './ora-create.component.html',
  styleUrls: ['./ora-create.component.css']
})
export class OraCreateComponent implements OnInit {
  router: Router
  http: HttpClient
  form!: FormGroup
  oraModel: OraCreate
  termek: Array<TeremModel>


  constructor(http: HttpClient, router: Router, private formBuilder: FormBuilder) {
    this.http = http
    this.router = router
    this.oraModel = new OraCreate()
    this.termek = []
  }

  ngOnInit(): void {
    this.getAllTerem()
    this.form = this.formBuilder.group({
      nev:['', Validators.required],
      leiras:['', Validators.required],
      terem:['', Validators.required],
      alkalmakSzama:['', Validators.required],
      oraKezdet:['', Validators.required],
      oraVeg:['', Validators.required],
    })
  }

  sendOraCreate(){
    if(this.form.valid){
      this.oraModel.tanarId = localStorage.getItem('neptun')!
      this.oraModel.nev = this.form.get('nev')?.value
      this.oraModel.leiras = this.form.get('leiras')?.value
      this.oraModel.teremID = this.form.get('terem')?.value
      this.oraModel.oraKezdet = this.form.get('oraKezdet')?.value
      this.oraModel.oraVeg = this.form.get('oraVeg')?.value
      this.oraModel.alkalmakSzama = this.form.get('alkalmakSzama')?.value
      console.log(this.oraModel)
      this.http.post<OraCreate>('http://localhost:5231/OraAPI/',this.oraModel)
      .subscribe((resp)=>{
        this.router.navigate(['/mainpage'])
      },
      (error) => {
        console.log(error)
      })
    }
  }

  getAllTerem(){
    this.http.get<any>('http://localhost:5231/TeremAPI')
    .subscribe((resp)=>{
      resp.map((t:any)=>{
        let ter = new TeremModel
        ter.nev = t.nev
        ter.elrendezes = t.elrendezes
        console.log(ter)
        this.termek.push(ter)
      })
    })
  }
}
