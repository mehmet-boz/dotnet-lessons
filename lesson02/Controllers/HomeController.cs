using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson02.Models;

namespace lesson02.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Random rnd = new Random();
        ViewBag.number = rnd.Next(0, 100);
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Contact()
    {
        ViewData["Name"] = "Barış Gürkan";
        ViewBag.ders = "Web Tasarım ve Programlama";
        return View();
    }
    public IActionResult Lessons()
    {
        string[] lessonList = {
            "Web Tabanlı Uygulama Geliştirme",
            "Grafik ve Canlandırma",
            "Oyun Programlama",
            "Mobil Uygulama Geliştirme",
            "Web Tabanlı İçerik Yönetimi",
            "Matematik",
            "Türkçe",
            "Beden Eğitimi"
        };

        ViewBag.lessons = lessonList;

        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }
}
