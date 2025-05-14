using Sube1.EmlakciLib;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KiralikEv k1 = new KiralikEv(20000, 1000, 3, "KiralikEv", 2, 100);
            KiralikEv k2 = new KiralikEv(25000, 1200, 4, "KiralikEv", 3, 120);
            KiralikEv k3 = new KiralikEv(30000, 1500, 5, "KiralikEv", 4, 150);


            var s1 = new SatilikEv(6000000, 4, "SatilikEv", 3, 120);
            var s2 = new SatilikEv(7000000, 5, "SatilikEv", 4, 150);
            var s3 = new SatilikEv(8000000, 6, "SatilikEv", 5, 200);

            Ev[] evler = {k1, k2, k3, s1, s2, s3};
            for (int i = 0; i < evler.Length; i++)
            {
                //    if (evler[i] is SatilikEv)
                //    {
                //        Console.WriteLine("!! SATILIK EV !!");
                //        SatilikEv sev = (SatilikEv)evler[i];
                //        Console.WriteLine(sev.EvBilgileri());
                //    }
                //else
                //    {
                //        Console.WriteLine("!! KİRALIK EV");
                //        KiralikEv kev = (KiralikEv)evler[i];
                //        Console.WriteLine(kev.KiralikEvBilgileri());
                //    }
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("-------------------");
            }



            //var evim3 = new Ev(2, 3, 120);
            //Console.WriteLine(evim3.EvBilgileri());

            //Console.WriteLine($"Bellekteki ev sayısı:{Ev.sayac}");


            //try
            //{
            //    var evim = new Ev();
            //    evim.Alan = 60;
            //    evim.Odasayisi = 3;
            //    evim.Semt = "Gazi";
            //    evim.Katno = 2;
            //    Console.WriteLine(Ev.Sayac);
            //    //evim.Buyukluk = "Küçük Ev";
            //    Console.WriteLine(evim.Buyukluk);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        }
}
}
//Ev evim = new Ev();//Ev classından nesne türetildi
//evim: Referans. Nesnelerin bellekteki adresini tutarlar.Belleğin STACK bölgesinde tutulurlar
//Ev: Class. Classlar aynı zamanda bir veri tipidir.
//new: Bellekte nesne oluşturmaya yarayan anahtar sözcük
//Nesne: new anahtar sözcüğü ile HEAP bölgesinde oluşturulurlar.
//Erişim Belirleyiciler(Access Modifiers)
//private: Sadece class içinden erişilebilir üyelerdir
//public: Class içinde tanımlanan üyeye her yerden erişim imkanı sağlar
//DRY: Don't Repeat Yourself