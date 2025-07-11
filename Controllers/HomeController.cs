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
        Integrante integrantee = bd.IniciarSesion(nombreUsuario, contraseña);
        List<Integrante> integrantes = bd.buscarEquipo(integrantee);
         ViewBag.Equipo = integrantes;
         if(integrantes.Count > 0)
         {
            return View("Equipo");
         }
         else return View("Index");
        
    }
   

}
