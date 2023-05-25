import { TeremModel } from "./teremModel"

export class Ora {
  public id: string = ''
  public nev: string = ''
  public leiras: string = ''
  public teremNev: string = ''
  public oraKezdet: Date = new Date()
  public oraVeg: Date = new Date()
  public alkalmakSzama: number[] = []
  public selectedAlkalom: number = 1
}

export class OraCreate{
  public tanarId: string = ''
  public nev: string = ''
  public leiras: string = ''
  public teremID: string = ''
  public oraKezdet: Date = new Date()
  public oraVeg: Date = new Date()
  public alkalmakSzama: number = 1
  public ulesrend: string = ''
}
