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
        Integrante integrantee = new Integrante();
        string equipo = integrantee.equipo;
        List<Integrante> integrantes = bd.buscarEquipo(integrantee, equipo);
         ViewBag.Equipo = integrantes;
         if(ViewBag.Equipo != null)
         {
            return View("Equipo");
         }
         else return View("Index");
        
    }
   

}
