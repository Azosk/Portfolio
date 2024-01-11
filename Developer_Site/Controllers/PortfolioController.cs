using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Developer_Site.Models;

namespace Developer_Site.Controllers;


public class PortfolioController : Controller
{
    private readonly ILogger<PortfolioController> _logger;

    public PortfolioController(ILogger<PortfolioController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Projects()
    {
        return View("Views/Portfolio/Projects.cshtml");
    }


    public IActionResult About()
    {
        return View("Views/Portfolio/About.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
