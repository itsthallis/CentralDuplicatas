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

