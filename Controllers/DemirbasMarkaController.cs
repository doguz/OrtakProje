using MessagePack;
using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using System.Drawing.Text;

namespace Proje.Controllers
{
    public class DemirbasMarkaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DemirbasMarkaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<DemirbasMarka> demirbasMarkaList = _context.demirbasMarka.ToList();
            return View(demirbasMarkaList);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Ekle(DemirbasMarka demirbasMarka)
        {
            _context.demirbasMarka.Add(demirbasMarka);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Guncelle(int Id)
        {
            var guncelle = _context.demirbasMarka.Find(Id);
            return View();
        }

        [HttpGet]
        public IActionResult Sil(DemirbasMarka demirbasMarka)
        {
            var sil = _context.demirbasMarka.Find(demirbasMarka.Id);
            sil.Id = demirbasMarka.Id;
            sil.Marka = demirbasMarka.Marka; 
            return View(demirbasMarka);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilPOST(int? Id)
        {
            var sil = _context.demirbasMarka.Find(Id);
            //var aracFromDbFirst = _context.arac.FirstOrDefault(x => x.Id == Id);
            //var aracFromDbSingle = _context.arac.SingleOrDefault(x => x.Id == Id);

            if (sil == null || sil.Id == 0)
            {
                return NotFound(nameof(Id));
            }
            else
            {
                _context.demirbasMarka.Remove(sil);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}
