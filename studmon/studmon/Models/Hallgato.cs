﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studmon.Models
{
    public class Hallgato
    {
        [Key]
        public string neptunKod { get; set; }

        public string nev { get; set; }

        public string kar { get; set; } //pl.: NIK

        public string kepzesNev { get; set; } //pl.: Bprof, Bsc

        [NotMapped]
        public List<Teljesitmeny> teljesitmeny { get; set; } //Órai teljesítmények

        public Hallgato(string neptunKod, string nev, string kar, string kepzesNev)
        {
            this.neptunKod = neptunKod;
            this.nev = nev;
            this.kar = kar;
            this.kepzesNev = kepzesNev;
            this.teljesitmeny = new List<Teljesitmeny>();
        }
    }
}
