using System.Collections.Generic;

namespace dugundavet.Models
{
    public class Repository
    {
        public static List<Cevap> cevaplar = new List<Cevap>(); // cevap sınıfından cevaplar adında list türünden bir nesne türettik.Her cevap bu list içerisinde yer alacak
        public static IEnumerable<Cevap> Cevaplar => cevaplar;
        public static void Cevapekle(Cevap cevap)
        {
            cevaplar.Add(cevap);
        }
    }
}
