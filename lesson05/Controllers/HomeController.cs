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
                        join y in db.Yazarlars on x.YazarId equals y.Id
                        join d in db.Dillers on x.DilId equals d.Id
                        orderby x.YayinTarihi descending
                        select new BookVM
                        {
                            Id = x.Id,
                            Adi = x.Adi,
                            YazarAdi = y.Adi + " " + y.Soyadi,
                            Dili = d.DilAdi,
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

    [Route("/Kitaplar")]
    [Route("/Kitaplar/Yazar/{yazarId?}")]
    [Route("/Kitaplar/Tur/{turId?}")]
    public IActionResult Kitaplar(int? yazarId, int? turId)
    {
        var kitaplar = new List<BookVM>();
        string title = "";

        if (yazarId == null && turId == null)
        {
            kitaplar = (from x in db.Kitaplars
                        join y in db.Yazarlars on x.YazarId equals y.Id
                        join d in db.Dillers on x.DilId equals d.Id
                        select new BookVM
                        {
                            Id = x.Id,
                            Adi = x.Adi,
                            YazarAdi = y.Adi + " " + y.Soyadi,
                            Dili = d.DilAdi,
                            Resim = x.Resim,
                            YayinTarihi = x.YayinTarihi.ToShortDateString()
                        }).ToList();
            title = "Tüm Kitaplar";
        }

        if (yazarId != null)
        {
            kitaplar = (from x in db.Kitaplars
                        join y in db.Yazarlars on x.YazarId equals y.Id
                        join d in db.Dillers on x.DilId equals d.Id
                        where x.YazarId == yazarId
                        orderby x.YayinTarihi descending
                        select new BookVM
                        {
                            Id = x.Id,
                            Adi = x.Adi,
                            YazarAdi = y.Adi + " " + y.Soyadi,
                            Dili = d.DilAdi,
                            Resim = x.Resim,
                            YayinTarihi = x.YayinTarihi.ToShortDateString()
                        }).ToList();
            var yazar = db.Yazarlars.Where(y => y.Id == yazarId).FirstOrDefault();
            title = yazar.Adi + " " + yazar.Soyadi + " yazarına ait kitaplar";
        }

        if (turId != null)
        {
            kitaplar = (from x in db.Turlertokitaplars
                        join k in db.Kitaplars on x.KitapId equals k.Id
                        where x.TurId == turId
                        orderby k.YayinTarihi descending
                        select new BookVM
                        {
                            Id = k.Id,
                            Adi = k.Adi,
                            YazarAdi = "Örnek Yazar",
                            Dili = "Türkçe",
                            Resim = k.Resim,
                            YayinTarihi = k.YayinTarihi.ToShortDateString()
                        }).Distinct().ToList();

            var tur = db.Turlers.Where(y => y.Id == turId).FirstOrDefault();
            title = tur.TurAdi + " türüne ait kitaplar";
        }

        ViewBag.PageTitle = string.Format("{0} - {1}", title, kitaplar.Count());
        return View(kitaplar);
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
