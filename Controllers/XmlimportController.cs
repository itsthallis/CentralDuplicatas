using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

    [Route("Lista")] 

    public class xmlimportController : Controller
    {
        public IActionResult Xmlimport()
        {
            return View();
        }
    }
}

