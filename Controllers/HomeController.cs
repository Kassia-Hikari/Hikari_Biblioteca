using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Hikari_Biblioteca.Models;

namespace Hikari_Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var agatha = BancoDeDados.Autores.FirstOrDefault(a => a.Id == 1);

            var livrosEmDestaque = BancoDeDados.Livros.ToList();

            // viewbag é tipo uma mochila que o controller usa pra mandar dados extras para a view... eu acho
            ViewBag.AutorDestaque = agatha;

            return View(livrosEmDestaque);
        }
    }
}