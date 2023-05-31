import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { studentModel } from '../_models/studentModel';
import { HttpClient } from '@angular/common/http';
import { performanceModel } from '../_models/performanceModel';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnChanges {



  @Input() studentList: Array<studentModel> | undefined;
  @Input() student: studentModel = { neptunKod: "H4Z8BT", nev: "Sörös Bence", kar: "NIK", kepzesNev: "BSc", orak: [], teljesitmeny: [] }
  @Input() gradeNumber: number = 99
  @Input() weekNumber: number = 12
  @Input() title: string = "title"
  @Input() class: any = {}
  @Input() coll: number =1
  @Input() rowIndex: number =1

  http: HttpClient
  changeNumber: number = 0


  constructor(http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.http = http
    //console.log(this.student);
    this.router = router
    
  }



  ngOnChanges(changes: SimpleChanges): void {
    this.changeNumber++
    let change = changes['gradeNumber']
    if (change?.currentValue && this.changeNumber>2) {

      
      //this.student.teljesitmeny[this.weekNumber] = change.currentValue
      if(change?.currentValue != change.previousValue){
        this.numbersCalc()
        this.apiCall(this.student.teljesitmeny[this.weekNumber-1]!.teljesitmenyID,change.currentValue)








        // this.http.put("http://localhost:5231/HallgatoAPI", this.student)
        // .subscribe(
        //   (success) => {
        //     console.log(success)
        //   },
        //   (error) => {
        //     console.log(error)
        //   }
        // )
      }
      
    }
  }

  private _display = "none";
  public get display() {
    return this._display;
  }
  public set display(value) {
    this._display = value;
  }
  nev: string = ""

  ngOnInit() {
    //console.log(this.rowIndex, this.coll);
    
  }
  openModal() {
    this.display = "block";
  }
  onCloseHandled() {
    this.display = "none";
  }

  changeValue(value: studentModel) {
    //console.log("onchange",value)
    this.nev = value.nev
    this.student = value
    this.modifyCell()
    this.onCloseHandled()
  }


  private numbersCalc(){
    this.route.params.subscribe((params)=>{
  
      this.weekNumber =  params['alkalom']})
  }


  private apiCall(performanceId: string, alma: number){
    let oraId = ""
    let weekNumber = 0
    this.route.params.subscribe((params)=>{
       oraId = params['id'];
       weekNumber = params['alkalom']})
  
    let newTeljesitmeny = {
    teljesitmenyID: parseInt(performanceId),
    hallgatoNeptunKod: this.student!.neptunKod,
    oraId: oraId,
    ertekeles: alma,
    weekNumber: weekNumber  }
    //console.log(newTeljesitmeny)

     this.http.put<any>(`http://localhost:5231/TeljesitmenyAPI/`, newTeljesitmeny, { responseType: 'json' })
         .subscribe(resp => {
           //console.log(resp)
         })
   }


   modifyCell(){

    let newOra = {
      id: this.class.id,
      nev: this.class.nev,
      leiras: this.class.leiras,
      teremID: this.class.teremID,
      tanarID: this.class.tanarID,
      alkalmakSzama: this.class.alkalmakSzama,
      oraKezdet: this.class.oraKezdet,
      oraVeg: this.class.oraVeg,
      ulesRend: this.class.ulesRend


    }
    // this.http.put<any>(`http://localhost:5231/OraAPI`, { responseType: 'json' })
    // .subscribe(resp => {
    //   console.log(resp)
     
    //   })
    let tmp = this.rowIndex*this.class.terem.elrendezes.split(",")[0].length+this.coll

    let elrendezes = newOra.ulesRend.split(" ")
    elrendezes[tmp]= this.student.neptunKod
    //console.log(elrendezes);

    newOra.ulesRend= elrendezes.join(" ")
    
    //console.log(newOra);   
    this.http.put<any>(`http://localhost:5231/OraAPI/`, newOra,{ responseType: 'json' })
      .subscribe(resp => {
        //console.log("Üllésrend beállítás");
        
        })
        this.numbersCalc()
        this.router.navigate([`/classroom/${this.class.id}/${this.weekNumber}`])
        //window.location.reload()
  }
 
    
  

  ulesRendMapping(e: any){
    //console.log(e);
    
    if(e){
      return e 
    }
    else{
      return " "
    }
  }



  saveUlesRend(){
    this.http.put<any>(`http://localhost:5231/OraAPI/${this.class}`, { responseType: 'json' })
      .subscribe(resp => {
        //console.log(resp)
  
        })
  }
  

}
