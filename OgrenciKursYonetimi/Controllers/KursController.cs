using Microsoft.AspNetCore.Mvc;
using OgrenciKursYonetimi.Web.Data;

namespace OgrenciKursYonetimi.Web.Controllers
{
    public class KursController : Controller
    {
        private readonly DataContext _context;

        public KursController(DataContext context)
        {
            _context = context;
        }

        // GET: Kurs/Index
        public IActionResult Index()
        {
            var kurslar = _context.Kurslar.ToList();
            return View(kurslar);
        }

        // GET: Kurs/Ekle
        public IActionResult Ekle()
        {
            return View();
        }

        // POST: Kurs/Ekle
        [HttpPost]
        public IActionResult Ekle(Kurs kurs)
        {
            if (ModelState.IsValid)
            {
                _context.Kurslar.Add(kurs);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kurs);
        }

        // GET: Kurs/Detay/5
        public IActionResult Detay(int id)
        {
            var kurs = _context.Kurslar.FirstOrDefault(k => k.KursId == id);
            if (kurs == null) return NotFound();
            return View(kurs);
            if (kurs == null) return NotFound();
            return View(kurs);
        }

        // POST: Kurs/Detay (Güncelleme)
        [HttpPost]
        public IActionResult Detay(Kurs kurs)
        {
            if (ModelState.IsValid)
            {
                _context.Kurslar.Update(kurs);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kurs);
        }

        // GET: Kurs/Sil/5
        public IActionResult Sil(int id)
        {
            var kurs = _context.Kurslar.FirstOrDefault(k => k.KursId == id);
            if (kurs == null) return NotFound();

            _context.Kurslar.Remove(kurs);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

