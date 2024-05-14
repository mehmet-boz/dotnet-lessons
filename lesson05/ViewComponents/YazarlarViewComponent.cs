using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson05.Models;
using lesson05.Models.Entities;
using lesson05.Models.ViewModels;
using System.Threading.Tasks;

namespace lesson05.Controllers;

public class YazarlarViewComponent : ViewComponent
{
    private readonly kitap_dbContext db = new kitap_dbContext();
    public YazarlarViewComponent(kitap_dbContext _db)
    {
        db = _db;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var yazarlar = (from x in db.Yazarlars
                        select new YazarlarSidebarVM
                        {   
                            Id = x.Id,
                            YazarAdi = x.Adi + " " + x.Soyadi,
                            KitapSayisi = (
                                from k in db.Kitaplars
                                where k.YazarId == x.Id
                                select k
                            ).Count()
                        }).OrderByDescending(a => a.KitapSayisi).Take(10).ToList();

        return View(yazarlar);
    }


}
