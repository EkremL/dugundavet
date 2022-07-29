

using System.ComponentModel.DataAnnotations;

namespace dugundavet.Models
{
    public class Cevap
    {
        // Koddaki Yeşil yazılı olanlar validation oluyor.
        [Required(ErrorMessage = "Lütfen ad kısmını boş bırakmayınız!")]  // bu alanın gerekli olduğunu tanımladık eğer veri girilmezse hata mesajı döndürüyoruz
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyad kısmını boş bırakmayınız!")] 
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen mail kısmını boş bırakmayınız!")]
        [EmailAddress]  // burada da uygun formata göre email girilmiş mi kontrol ediyoruz.
        public string E_mail { get; set; }
        [Required(ErrorMessage = "Lütfen numarayı kısmını boş bırakmayınız!")]
        public ulong Phone_Number { get; set; }

        [Required(ErrorMessage = "Lütfen bir seçim yapın!")]
        public bool? WillYouJoin { get; set; } //burada soru işareti koymamızın sebebi evet hayır ın yanında null değer de döndürebilmesidir.Bu yüzden validation ile kontrol ediyoruz.

    }
}
