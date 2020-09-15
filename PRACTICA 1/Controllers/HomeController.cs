using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PRACTICA_1.Models;
using Microsoft.AspNetCore.Mvc;


namespace PRACTICA_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Captura()
        {
            return View();
        }

        public IActionResult Resultado(Valores x)
        {
            var resultados = x.Valor1 + x.Valor2;
            return View(resultados);
        }
    }
}
