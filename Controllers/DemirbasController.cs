using MessagePack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proje.Models;

namespace Proje.Controllers
{
    public class DemirbasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DemirbasController(ApplicationDbContext context)
        {
                _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Demirbas> demirbasList = _context.demirbas.ToList();
            return View(demirbasList);
        }

        DemirbasMarkaModel ddlMarkaModel = new DemirbasMarkaModel();
        public IActionResult Ekle()
        {
            ddlMarkaModel.MarkaList = new SelectList(_context.aracMarka.OrderBy(o => o.Marka), "Id", "Marka");
            ddlMarkaModel.ModelList = new SelectList(_context.aracModel.OrderBy(o => o.Model), "Id", "Model");

            List<SelectListItem> cinsi = new List<SelectListItem>();
            cinsi = (from i in _context.demirbasCins.ToList()
                       select new SelectListItem
                       {
                           Text = i.Cinsi,
                           Value = i.Id.ToString()
                       }).ToList();
            ViewBag.demirbasCinsiValues = cinsi;

            ViewBag.aracMarkaValues = ddlMarkaModel.MarkaList;
            ViewBag.aracModelValues = ddlMarkaModel.ModelList;
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Demirbas demirbas)
        {
            _context.demirbas.Add(demirbas);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult DemirbasMarkaModelDDL(int item)
        {
            var model = (
                from mrk in _context.demirbasModel
                join mdl in _context.demirbasMarka
                on mrk.DemirbasMarka.Id equals mdl.Id
                where mrk.DemirbasMarka.Id == item
                select new
                {
                    Text = mrk.Model,
                    Value = mrk.Id.ToString()
                }).ToList();
            return Json(model);
        }


    }
}
