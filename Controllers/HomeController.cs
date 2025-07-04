using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06.Models;
using Newtonsoft.Json;

namespace TP06.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
