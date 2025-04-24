using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OgrenciKursYonetimi.Web.Data;

namespace OgrenciKursYonetimi.Web.Controllers
{
    public class KursKayitController : Controller
    {
        private readonly DataContext _context;

        public KursKayitController(DataContext context)
        {
            _context = context;
        }

        // GET: KursKayit/Index
        public async Task<IActionResult> Index()
        {
            var kursKayitlari = await _context.KursKayitlar
                .Include(x => x.Ogrenci)
                .Include(x => x.Kurs)
                .ToListAsync();

            return View(kursKayitlari);
        }

        // GET: KursKayit/Create
        public IActionResult Create()
        {
            ViewBag.Ogrenciler = new SelectList(_context.Ogrenciler.ToList(), "OgrenciId", "OgrenciAdSoyad");
            ViewBag.Kurslar = new SelectList(_context.Kurslar.ToList(), "KursId", "Baslik");

            return View();
        }

        // POST: KursKayit/Create
        [HttpPost]
        public IActionResult Create(KursKayit kursKayit)
        {
            kursKayit.KayitTarihi = DateTime.UtcNow;
            _context.KursKayitlar.Add(kursKayit);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: KursKayit/Edit/5
        public IActionResult Edit(int id)
        {
            var kayit = _context.KursKayitlar.FirstOrDefault(x => x.KayitId == id);
            if (kayit == null) return NotFound();

            ViewBag.Ogrenciler = new SelectList(_context.Ogrenciler.ToList(), "OgrenciId", "OgrenciAdSoyad", kayit.OgrenciId);
            ViewBag.Kurslar = new SelectList(_context.Kurslar.ToList(), "KursId", "Baslik", kayit.KursId);

            return View(kayit);
        }

        // POST: KursKayit/Edit/5
        [HttpPost]
        public IActionResult Edit(KursKayit kursKayit)
        {
            if (ModelState.IsValid)
            {
                _context.KursKayitlar.Update(kursKayit);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ogrenciler = new SelectList(_context.Ogrenciler.ToList(), "OgrenciId", "OgrenciAdSoyad", kursKayit.OgrenciId);
            ViewBag.Kurslar = new SelectList(_context.Kurslar.ToList(), "KursId", "Baslik", kursKayit.KursId);
            return View(kursKayit);
        }

        // GET: KursKayit/Delete/5
        public IActionResult Delete(int id)
        {
            var kayit = _context.KursKayitlar.FirstOrDefault(x => x.KayitId == id);
            if (kayit == null) return NotFound();

            _context.KursKayitlar.Remove(kayit);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


