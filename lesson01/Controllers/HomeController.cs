using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson01.Models;

namespace lesson01.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }
    public IActionResult Gallery()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }


}
