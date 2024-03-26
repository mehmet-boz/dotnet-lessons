using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson05.Models;
using lesson05.Models.Entities;
using lesson05.Models.ViewModels;

namespace lesson05.Controllers;

public class HomeController : Controller
{
    private readonly kitap_dbContext db = new kitap_dbContext();
    public HomeController(kitap_dbContext _db)
    {
        db = _db;
    }

    public IActionResult Index()
    {

        var KitapListesi = new List<BookVM>();
        KitapListesi = (from x in db.Kitaplars
                        orderby x.YayinTarihi descending
                        select new BookVM
                        {
                            Id = x.Id,
                            Adi = x.Adi,
                            YazarAdi = x.YazarId.ToString(),
                            Dili = x.DilId.ToString(),
                            Resim = x.Resim,
                            YayinTarihi = x.YayinTarihi.ToShortDateString()
                        }).Take(10).ToList(); //sonuçları sınırlama - limit

        // KitapListesi = (from x in db.Kitaplars
        //                 orderby x.Adi //sıralama
        //                 select new BookVM
        //                 {
        //                     Id = x.Id,
        //                     Adi = x.Adi,
        //                     YazarAdi = x.YazarId.ToString(),
        //                     Dili = x.DilId.ToString(),
        //                     Resim = x.Resim,
        //                     YayinTarihi = x.YayinTarihi.ToShortDateString()
        //                 }).ToList(); //listeye dönüştürme

        // KitapListesi = (from x in db.Kitaplars
        //                 orderby x.YayinTarihi descending //azalan sıralama
        //                 select new BookVM
        //                 {
        //                     Id = x.Id,
        //                     Adi = x.Adi,
        //                     YazarAdi = x.YazarId.ToString(),
        //                     Dili = x.DilId.ToString(),
        //                     Resim = x.Resim,
        //                     YayinTarihi = x.YayinTarihi.ToShortDateString()
        //                 }).ToList();

        // KitapListesi = (from x in db.Kitaplars
        //                 where x.YazarId == 5 //seçme
        //                 select new BookVM
        //                 {
        //                     Id = x.Id,
        //                     Adi = x.Adi,
        //                     YazarAdi = x.YazarId.ToString(),
        //                     Dili = x.DilId.ToString(),
        //                     Resim = x.Resim,
        //                     YayinTarihi = x.YayinTarihi.ToShortDateString()
        //                 }).ToList();

        // KitapListesi = (from x in db.Kitaplars
        //                 where x.SayfaSayisi > 99 && x.SayfaSayisi < 201 //between
        //                 select new BookVM
        //                 {
        //                     Id = x.Id,
        //                     Adi = x.Adi,
        //                     YazarAdi = x.YazarId.ToString(),
        //                     Dili = x.DilId.ToString(),
        //                     Resim = x.Resim,
        //                     YayinTarihi = x.YayinTarihi.ToShortDateString()
        //                 }).ToList();

        // KitapListesi = (from x in db.Kitaplars
        //                 let ortalama = db.Kitaplars.Average(x => x.SayfaSayisi) //sorgu içinde sorgu
        //                 where x.SayfaSayisi > ortalama
        //                 select new BookVM
        //                 {
        //                     Id = x.Id,
        //                     Adi = x.Adi,
        //                     YazarAdi = x.YazarId.ToString(),
        //                     Dili = x.DilId.ToString(),
        //                     Resim = x.Resim,
        //                     YayinTarihi = x.YayinTarihi.ToShortDateString()
        //                 }).ToList();

        // KitapListesi = (from x in db.Kitaplars
        //                 let yil = x.YayinTarihi.Year //sorgu içinde değişken
        //                 where yil == 2022
        //                 select new BookVM
        //                 {
        //                     Id = x.Id,
        //                     Adi = x.Adi,
        //                     YazarAdi = x.YazarId.ToString(),
        //                     Dili = x.DilId.ToString(),
        //                     Resim = x.Resim,
        //                     YayinTarihi = x.YayinTarihi.ToShortDateString()
        //                 }).ToList();
        return View(KitapListesi);
    }


    [Route("/Kitap/{id}")]
    public IActionResult KitapDetay(int id)
    {
        var kitap = (from x in db.Kitaplars
                     where x.Id == id
                     select x).FirstOrDefault();
        return View(kitap);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
