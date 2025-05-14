using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            this.Satisfiyat = satisfiyat;
        }

        public double Satisfiyat { get; set; }

        public override string EvBilgileri()
        {
            return $"{base.Odasayisi} oda, {base.Katno} kat, {base.Alan} m², {base.Semt} ({base.Buyukluk})\nSatış Fiyatı:, {Satisfiyat}:₺";
        }
    }
}
//Name Hiding: Türeyen classlarda, base clastaki üylerin ismiyle aynı isimli bir üye tanımlanırsa, artık türeyen class referansıyla base classtaki üyeye erişilemez.
