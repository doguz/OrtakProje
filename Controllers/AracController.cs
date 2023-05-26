using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proje.Models;

namespace Proje.Controllers
{
    public class AracController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AracController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var aracList = _context.arac.ToList();
            IEnumerable<Arac> aracList = _context.arac.ToList();
            return View(aracList);
        }

        AracMarkaModel ddlMarkaModel = new AracMarkaModel();

        [HttpGet]
        public IActionResult Ekle()
        {
            ddlMarkaModel.MarkaList = new SelectList(_context.aracMarka.OrderBy(o => o.Marka), "Id", "Marka");
            ddlMarkaModel.ModelList = new SelectList(_context.aracModel.OrderBy(o => o.Model), "Id", "Model");

            List<SelectListItem> yil = new List<SelectListItem>();
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1950; i--)
            {
                yil.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }
            List<SelectListItem> yakit = (from i in _context.aracYakit.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Yakit,
                                              Value = i.Id.ToString()
                                          }).ToList();
            List<SelectListItem> aidiyet = (from i in _context.aracAidiyet.ToList()
                                            select new SelectListItem
                                            {
                                                Text = i.Aidiyet,
                                                Value = i.Id.ToString()
                                            }).ToList();
            List<SelectListItem> renk = (from i in _context.renk.ToList()
                                         select new SelectListItem
                                         {
                                             Text = i.Rengi,
                                             Value = i.Id.ToString()
                                         }).ToList();
            List<SelectListItem> vites = (from i in _context.aracVitesTipi.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.Vites,
                                              Value = i.Id.ToString()
                                          }).ToList();

            ViewBag.aracModelYiliValues = yil;
            //ViewBag.aracKategoriValues = kategori;
            ViewBag.aracMarkaValues = ddlMarkaModel.MarkaList;
            ViewBag.aracModelValues = ddlMarkaModel.ModelList;
            ViewBag.aracYakitValues = yakit;
            ViewBag.aracAidiyetValues = aidiyet;
            ViewBag.renkValues = renk;
            ViewBag.aracVitesTipiValues = vites;

            return View();
        }
        //public ActionResult GetModelByMarkaId(int markaId)
        //{
        //    var modelData = _context.aracModel.Where(m => m.AracMarkaId == markaId).Select(x => new
        //    {
        //        text = x.Model,
        //        value = x.Id
        //    }).ToList();
        //    return Json(modelData);
        //}


        [HttpPost]
        public IActionResult Ekle(Arac aracEkle)
        {
            //if(aracEkle.ResmiPlaka==aracEkle.ResmiPlaka.ToString())
            //{
            //    ModelState.AddModelError("Custom", "Uyarı!");
            //}
            //if (ModelState.IsValid)
            //{
            // aracEkle.AracAidiyet = new SelectList(_context.aracAidiyet,);
            _context.arac.Add(aracEkle);
            _context.SaveChanges();
            TempData["success"] = "Kayıt ekleme başarılı.";
            return RedirectToAction("Index");
            //}
            //return RedirectToAction("Index");
        }


        public JsonResult AracMarkaModelDDL(int item)
        {
            var model = (
                from mrk in _context.aracModel
                join mdl in _context.aracMarka
                on mrk.AracMarka.Id equals mdl.Id
                where mrk.AracMarka.Id == item
                select new
                {
                    Text = mrk.Model,
                    Value = mrk.Id.ToString()
                }).ToList();
            return Json(model);
        }


        [HttpGet]
        public IActionResult Guncelle(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var aracGuncelle = _context.arac.Find(Id);
            //var aracFromDbFirst = _context.arac.FirstOrDefault(x => x.Id == Id);
            //var aracFromDbSingle = _context.arac.SingleOrDefault(x => x.Id == Id);

            if (aracGuncelle == null)
            {
                return NotFound(nameof(Id));
            }
            return View(aracGuncelle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Guncelle(Arac aracEkle)
        {
            //if(aracEkle.ResmiPlaka==aracEkle.ResmiPlaka.ToString())
            //{
            //    ModelState.AddModelError("Custom", "Uyarı!");
            //}
            if (ModelState.IsValid)
            {
                _context.arac.Update(aracEkle);
                _context.SaveChanges();
                TempData["success"] = "Kayıt güncelleme başarılı.";
                return RedirectToAction("Index");
            }
            return View(aracEkle);
        }

        [HttpGet]
        public IActionResult Sil(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var arac = _context.arac.Find(Id);
            //var aracFromDbFirst = _context.arac.FirstOrDefault(x => x.Id == Id);
            //var aracFromDbSingle = _context.arac.SingleOrDefault(x => x.Id == Id);

            if (arac == null)
            {
                return NotFound(nameof(Id));
            }
            return View(arac);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilPOST(int? Id)
        {
            var arac = _context.arac.Find(Id);
            //var aracFromDbFirst = _context.arac.FirstOrDefault(x => x.Id == Id);
            //var aracFromDbSingle = _context.arac.SingleOrDefault(x => x.Id == Id);

            if (arac == null)
            {
                return NotFound(nameof(Id));
            }

            _context.arac.Remove(arac);
            _context.SaveChanges();
            TempData["success"] = "Kayıt silme başarılı.";
            return RedirectToAction("Index");
        }

        //public IActionResult Sil(int Id)
        //{
        //    var aracSil = _context.arac.Find(Id);
        //    _context.arac.Remove(aracSil);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}


        public IActionResult AracResmiEkle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AracResmiEkle([Bind("ImageId,ImageName,Aciklama")] Resimler resim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resim);
        }

    }
}
