using SisCaVet.Data;
using SisCaVet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SisCaVet.Controllers
{    
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (Veterinario v)
        {
            if(!ModelState.IsValid)
                return View(v);

            using(var data = new LoginData())
            {
                Veterinario veterinario = data.Read(v.Email, v.Senha);

                if(veterinario == null)
                {
                    ViewBag.Mensagem = "Falha na autenticação";
                    return View(v);
                }
                else
                {
                    HttpContext.Session.SetString("Veterinario", veterinario.Nome);
                    HttpContext.Session.SetInt32("Id", veterinario.Id);
                    
                    return RedirectToAction("Index", "Home");
                }
            }
        } 
    }
}