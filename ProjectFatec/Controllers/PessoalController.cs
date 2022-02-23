using Microsoft.AspNetCore.Mvc;
using ProjectFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFatec.Controllers
{
    public class PessoalController : Controller
    {
        public static List<Pessoal> lsPessoal = new List<Pessoal>();
        public IActionResult Index()
       
        {
            return View(lsPessoal);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }

       /* [HttpPost]*/
        public IActionResult salvar(Pessoal p)
        {
            lsPessoal.Add(p);
            return RedirectToAction("Index");
        }

    }
}
