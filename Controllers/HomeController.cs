using Microsoft.AspNetCore.Mvc;
using SisCaVet.Controllers;

namespace ECommerce.Controllers{
    
    [AuthFilter]
    public class HomeController : Controller
    {        
       [HttpGet] // padrão, não é necessario colocar ATRIBUTO
        public ActionResult Index()
         {
            // retorna view(Html)
            return View(); 

        }
    }
}