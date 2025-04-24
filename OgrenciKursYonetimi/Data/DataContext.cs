using Microsoft.EntityFrameworkCore;

namespace OgrenciKursYonetimi.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<KursKayit> KursKayitlar { get; set; }
    }
}
