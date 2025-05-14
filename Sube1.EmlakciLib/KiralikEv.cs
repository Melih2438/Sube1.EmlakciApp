using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(double kira, double depozito, int odasayisi, string semt, int katno, double alan):base(odasayisi,katno,alan,semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;           
        }

        public double Kira { get; set; }
        public double Depozito { get; set; }

        public override string EvBilgileri()
        {
            return $"{base.Odasayisi} oda, {base.Katno} kat, {base.Alan} m², {base.Semt} ({base.Buyukluk})\nKira:, Depozito: {Depozito}₺";
        }
    }
}

//internal: Yalnızca aynı namespace içindeki classlar tarafından erişilebilir.
