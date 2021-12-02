﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloForm
{
  public  class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }
        public string Sinifi { get; set; }
        public bool SecmeliDersAliyorMu { get; set; }
        public List<string> AldigiSecmeliDersler { get; set; } = new List<string>();
       
        private byte _yas;
        public byte Yas
        {
            get
            {
                _yas = Convert.ToByte(DateTime.Now.Year - DTarihi.Year);
                return _yas;
            }

        }

        public override string ToString()
        {
            return this.Ad + " " + this.Soyad.ToUpper() + " " +
                this.Yas + " yaşında "+this.AldigiSecmeliDersler.Count+" adet seçmeli dersi var";
        }
    }
}
