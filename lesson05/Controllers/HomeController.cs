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
        // SELECT * FROM kitaplar WHERE yazarId=20;
        var KitapListesi = new List<BookVM>();
        KitapListesi = (from x in db.Kitaplars
                        orderby x.Adi
                        select new BookVM
                        {
                            Id = x.Id,
                            Adi = x.Adi,
                            YazarAdi = x.YazarId.ToString(),
                            Dili = x.DilId.ToString(),
                            Resim = x.Resim,
                            YayinTarihi = x.YayinTarihi.ToShortDateString()
                        }).ToList();

        return View(KitapListesi);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
