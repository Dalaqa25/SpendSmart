using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _Net_Projetcts.Models;

namespace _Net_Projetcts.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly SpendSmartDbContext _context;

    public HomeController(ILogger<HomeController> logger, SpendSmartDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Expanses()
    {
        var allExpanses = _context.Expanses.ToList();
        return View(allExpanses);
    }


    public IActionResult CreateEditExpanses()
    {
        return View();
    }

    public IActionResult CreateEditExpansesForm(Expanse model)
    {
        _context.Expanses.Add(model);

        _context.SaveChanges();

        return RedirectToAction("Expanses");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
