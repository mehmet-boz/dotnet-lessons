using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson04.Models.Entities; /***********/

namespace lesson04.Controllers;

public class HomeController : Controller
{
    private readonly kahveContext dbContext = new kahveContext();
    public HomeController(kahveContext _dbContext)
    {
        dbContext = _dbContext;
    }

    public IActionResult Index()
    {
        var urunListesi = dbContext.Urunlers.ToList();
        return View(urunListesi);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
