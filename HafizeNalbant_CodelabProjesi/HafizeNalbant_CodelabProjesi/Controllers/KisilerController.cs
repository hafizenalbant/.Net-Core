using HafizeNalbant_CodelabProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HafizeNalbant_CodelabProjesi.Controllers
{
    public class KisilerController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.kisiler.ToList();
            return View(degerler);
        }


        [HttpGet]
        public IActionResult YeniKisi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniKisi(Kişiler d)
        {
            c.kisiler.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult KisiSil(int id)
        {
            var kisi = c.kisiler.Find(id);
            c.kisiler.Remove(kisi);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult KisiGetir(int id)
        {
            var kisi = c.kisiler.Find(id);
            return View("KisiGetir", kisi);
        }

        public IActionResult KisiGuncelle(Kişiler d)
        {
            var kisi = c.kisiler.Find(d.id);
            kisi.Ad = d.Ad;
            kisi.Soyad = d.Soyad;
            kisi.Bölüm = d.Bölüm;
            kisi.Yaş = d.Yaş;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
