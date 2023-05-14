import { classModel } from "./classModel"
import { performanceModel } from "./performanceModel"

export class studentModel{
    public neptunKod: string = ''
    public nev : string = ''
    public kar: string = ''
    public kepzesNev: string = ''
    public orak : Array<classModel> = []
    public teljesitmeny:Array<performanceModel> = []
}
