using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission5Assignment.Models;

namespace Mission5Assignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); //this function here handles the home page
    }

    public IActionResult Calculator() //basically the door that opens the calculator page
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}