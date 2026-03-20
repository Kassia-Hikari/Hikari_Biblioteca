using Microsoft.AspNetCore.Mvc;
using Hikari_Biblioteca.Models;
using System.Linq;

namespace Hikari_Biblioteca.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Detalhes(int id)
        {
            var autorEncontrado = BancoDeDados.Autores.FirstOrDefault(a => a.Id == id);

            if (autorEncontrado == null)
            {
                return NotFound();
            }

            autorEncontrado.LivrosRelacionados = BancoDeDados.Livros.Where(l => l.AutorId == id).ToList();

            return View(autorEncontrado);
        }
    }
}