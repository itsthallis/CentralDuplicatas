using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

    [Route("Termos")] 

    public class TermosController : Controller
    {
        public IActionResult Termos()
        {
            return View();
        }
    }
}

