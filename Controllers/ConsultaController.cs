using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SisCaVet.Models;
using SisCaVet.Data;

namespace SisCaVet.Controllers
{
    [AuthFilter]
    public class ConsultaController : Controller
    {
        public IActionResult Index()
        { 
            using(var data = new ConsultaData())
            {
                return View(data.Read());
            }
        }

        public IActionResult Create()
        { 
            using(var data = new AnimalData())
            {
                ViewBag.Animal = data.Read();
            }

            using(var data = new VeterinarioData())
            {
                ViewBag.Veterinario = data.Read();
            }

            using(var data = new ProcedimentoData())
            {
                ViewBag.Procedimento = data.Read();
            }

            using(var data = new ConsultaData())
            {
                return View();
            }
        }
/*
        [HttpPost]
         public IActionResult Create(Consulta e)
        {   
            if(!ModelState.IsValid)
            {
                return View(e);
            }
            using(var data = new ConsultaData())
                data.Create(e);

            return RedirectToAction("Index");                    
        }*/

        public IActionResult Delete (int id)
        {
            using(var data = new ConsultaData())
                data.Delete(id);

            return RedirectToAction("Index");  
        }        
        
        /*
        [HttpGet]
        public IActionResult Update(int id)
        {
            using(var data = new ConsultaData())           
            return View(data.Read(id));
        }

        [HttpPost]
        public IActionResult Update(int id, Consulta e)
        {
            e.Id = id;

            if(!ModelState.IsValid)
            {
                return View(e);
            }

            using(var data = new ConsultaData())
                data.Update(e);

            return  RedirectToAction("Index");
        }
    
    */
    
    }
}
