using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wymiary_Prostokąta.Models;
using Wymiary_Prostokąta.Services;

namespace Wymiary_Prostokąta.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProstokatService _prostokatService;

        public HomeController(IProstokatService prostokatService)
        {
            _prostokatService = prostokatService;
        }

        [HttpGet]
        public IActionResult Formularz()
        {
            var model = new ProstokatViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Oblicz(ProstokatViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Oblicz pole prostokąta
                var pole = _prostokatService.ObliczPole(model.Wysokosc, model.Szerokosc, model.Jednostka);
                // Ustaw wynik i ustaw flagę CzyObliczono na true
                model.Wynik = pole;
                model.CzyObliczono = true;
                // Przekazanie modelu z powrotem do widoku
                return View("Formularz", model);
            }
            // Jeśli model jest nieprawidłowy, zwróć widok Formularz z aktualnym modelem
            return View("Formularz", model);
        }




        public IActionResult Wynik(double pole)
        {
            ViewBag.Pole = pole; // Przekazanie pola prostokąta do widoku
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
