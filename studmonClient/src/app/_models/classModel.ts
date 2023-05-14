import { studentModel } from "./studentModel"

export class classModel{
    public Id : string = ''
    public nev : string = ''
    public leiras : string = ''
    public teremId : string = ''
    public tanarId : string = ''
    public alkalmakSzama : number = 0
    public oraKezdet : Date = new Date
    public oraVeg : Date = new Date
    public hallgatokColl : Array<studentModel> = []
    public teljesitmenyColl : Array<number> = []
    public ulesRend : string = ''
  }