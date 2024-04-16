using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson05.Models;
using lesson05.Models.Entities;
using lesson05.Models.ViewModels;
using System.Threading.Tasks;

namespace lesson05.Controllers;

public class NavbarViewComponent : ViewComponent
{
    private readonly kitap_dbContext db = new kitap_dbContext();
    public NavbarViewComponent(kitap_dbContext _db)
    {
        db = _db;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var turler = (from x in db.Turlers
                      select new NavbarVM
                      {
                          Id = x.Id,
                          TurAdi = x.TurAdi
                      }).ToList();

        return View(turler);
    }


}
