using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

[Route("Termos")] 

    public class termosController : Controller
    {
        public IActionResult termos()
        {
            return View();
        }
    }
}

