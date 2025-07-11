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
    public IActionResult IniciarSesion(string nombreUsuario, string contraseña)
    {
        BD bd = new BD();
        List<Integrante> integrante = bd.IniciarSesion(nombreUsuario, contraseña);
        HttpContext.Session.SetString("BD", Objeto.ObjectToString(bd));
        return View("Index");
    }
    public IActionResult mostrarEquipo()
    {
        BD bd = Objeto.StringToObject<BD>(HttpContext.Session.GetString("bd"));
        Integrante integrante = new Integrante();
        string equipo = Integrante.equipo;
        HttpContext.Session.SetString("Integrante", Objeto.ObjectToString(integrante));
        List<Integrante> integrantes = bd.buscarEquipo(integrante, equipo);
         ViewBag.Equipo = integrantes;
        return View("Equipo");
    }

}
