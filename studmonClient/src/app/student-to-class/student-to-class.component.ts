import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { studentModel } from '../_models/studentModel';
import { findIndex } from 'rxjs';

@Component({
  selector: 'app-student-to-class',
  templateUrl: './student-to-class.component.html',
  styleUrls: ['./student-to-class.component.css']
})
export class StudentToClassComponent implements OnInit {
  router: Router
  http: HttpClient
  oraId: string | undefined;
  unsubscribedStudents: Array<studentModel>
  subscribedStudents: Array<studentModel>

  constructor(http: HttpClient, router: Router, private route: ActivatedRoute) {
    this.http = http
    this.router = router
    this.unsubscribedStudents = []
    this.subscribedStudents = []
  }
  ngOnInit(): void {
    this.getUnSubscribedStudents()
  }

  //MEGMONDJA KIK VANNAK FELIRATKOZTATVA AZ ÓRÁRA ÉS KIK NEM
  async getUnSubscribedStudents() {
    await this.route.params.subscribe(params => {
      this.oraId = params['id']
      console.log(this.oraId)

      this.http.get<any>('http://localhost:5231/HallgatoAPI')
        .subscribe(resp => {
          console.log(resp)
          resp.map((t: any) => {
            let uss = new studentModel
            uss.nev = t.nev
            uss.neptunKod = t.neptunKod
            uss.kar = t.kar
            uss.kepzesNev = t.kepzesNev
            uss.orak = t.orak
            let oraKereses = t.orak.find((t:any)=>t.oraId===this.oraId)
            if (oraKereses===undefined) {
              this.unsubscribedStudents.push(uss)
            }else{
              this.subscribedStudents.push(uss)
            }
          })
          console.log("NEM FELIRATKOZOTTAK",this.unsubscribedStudents)
          console.log("FELIRATKOZOTTAK",this.subscribedStudents)
        })
    })

  }

  async removeStudent(item:studentModel){
    console.log(item)
    await this.http.get<any>('http://localhost:5231/OMToHMAPI')
    .subscribe((resp)=>{
      let keresettKapcsolat = resp.find((t:any)=>t.hallgatoId === item.neptunKod && t.oraId === this.oraId)
      this.http.delete<any>('http://localhost:5231/OMToHMAPI/'+keresettKapcsolat.id)
      .subscribe((resp)=>{
        this.unsubscribedStudents.push(item)
        let index = this.subscribedStudents.findIndex((t:any)=>t.neptunKod === item.neptunKod)
        this.subscribedStudents.splice(index,1)
      })
    })
    //this.http.delete<any>('')
  }

}
