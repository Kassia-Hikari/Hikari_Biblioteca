using Microsoft.AspNetCore.Mvc;
using Hikari_Biblioteca.Models;
using System.Linq;

namespace Hikari_Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index(string pesquisa)
        {
            var livrosParaMostrar = BancoDeDados.Livros.AsEnumerable(); //aqui puxa do bd static

            if (!string.IsNullOrEmpty(pesquisa))
            {
                livrosParaMostrar = livrosParaMostrar.Where(l => l.Titulo.Contains(pesquisa, System.StringComparison.OrdinalIgnoreCase));
            }

            return View(livrosParaMostrar.ToList());
        }

        public IActionResult Detalhes(int id)
        {
            var livroEncontrado = BancoDeDados.Livros.FirstOrDefault(l => l.Id == id);

            if (livroEncontrado == null) return NotFound();

            return View(livroEncontrado);
        }
    }
}