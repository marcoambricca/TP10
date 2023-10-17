using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.series = BD.ObtenerSeries();
        return View();
    }

    public List<Temporada> VerDetalleTemporadas(int IdSerie)
    {
        return BD.ObtenerTemporadas(IdSerie);
    }
    public List<Actor> VerDetalleActores(int IdSerie)
    {
        return BD.ObtenerActores(IdSerie);
    }

    public List<string> VerDetalleInfo(int IdSerie)
    {
        List<Actor> listaactores = BD.ObtenerActores(IdSerie);
        List<Temporada> listatemporadas = BD.ObtenerTemporadas(IdSerie);
        List<string> info = new List<string>();
        info.Add("la cantidad de actores de la serie es de "+(listaactores.Count) +" y la cantidad de temporadas es de "+(listatemporadas.Count));
        return info;
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
