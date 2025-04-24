using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgrenciKursYonetimi.Web.Data;

namespace OgrenciKursYonetimi.Web.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly DataContext _context;

        public OgrenciController(DataContext context)
        {
            _context = context;
        }

        // GET: Ogrenci/Ekle
        public IActionResult Ekle()
        {
            return View();
        }

        // POST: Ogrenci/Ekle
        [HttpPost]
        public IActionResult Ekle(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                _context.Ogrenciler.Add(ogrenci);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogrenci);
        }

        // GET: Ogrenci/Liste
        public IActionResult Index()
        {
            var ogrenciler = _context.Ogrenciler.ToList();
            return View(ogrenciler);
        }

        // GET: Ogrenci/Detay/5
        public IActionResult Detay(int id)
        {
            var ogrenci = _context.Ogrenciler
        .Include(x => x.KursKayitlari)
        .ThenInclude(x => x.Kurs)
        .FirstOrDefault(x => x.OgrenciId == id);
            if (ogrenci == null) return NotFound();
            return View(ogrenci);
        }


        // POST: Ogrenci/Detay/5 (Güncelle)
        [HttpPost]
        public IActionResult Detay(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                _context.Ogrenciler.Update(ogrenci);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Kurs bilgilerini tekrar çek (YOKSA hata verir)
            ogrenci.KursKayitlari = _context.KursKayitlar
                .Where(k => k.OgrenciId == ogrenci.OgrenciId)
                .Include(k => k.Kurs)
                .ToList();

            return View(ogrenci);
        }

        // GET: Ogrenci/Sil/5
        public IActionResult Sil(int id)
        {
            var ogrenci = _context.Ogrenciler.FirstOrDefault(o => o.OgrenciId == id);
            if (ogrenci == null) return NotFound();

            _context.Ogrenciler.Remove(ogrenci);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}

