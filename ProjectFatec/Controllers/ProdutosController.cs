using Microsoft.AspNetCore.Mvc;
using ProjectFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFatec.Controllers
{
    public class ProdutosController : Controller
    {
        public static List<Produto> lsProdutos = new List<Produto>();
        public IActionResult Index()
        {
            return View(lsProdutos);
        }

        public IActionResult Produtos()
        {
            return View();
        }
        public IActionResult salvar(Produto p)
        {
            lsProdutos.Add(p);
            return RedirectToAction("Index");
        }
    }
}
