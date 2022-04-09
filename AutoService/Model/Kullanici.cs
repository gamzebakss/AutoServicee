﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Kullanici
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string Email{ get; set; }
        public string Sifre { get; set; }
        public string TicariUnvan { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public short MusteriTipi { get; set; }
        public short KullaniciTipi { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        //Veritabanındaki Smallınt olarak tanımlama kolanlar # tarafından SHORT tipiyle tanımlanmalıdır.
        public string ProfilFoto { get; set; }







    }
}
