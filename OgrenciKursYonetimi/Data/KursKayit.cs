using System.ComponentModel.DataAnnotations;

namespace OgrenciKursYonetimi.Web.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId{ get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci? Ogrenci { get; set; }
        public int KursId { get; set; }
        public Kurs? Kurs { get; set; }

        public DateTime KayitTarihi { get; set; } = DateTime.UtcNow;

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}
