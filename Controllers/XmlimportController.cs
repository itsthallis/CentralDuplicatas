using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

    [Route("Lista")] 

    public class XmlimportController : Controller
    {
        public IActionResult Xmlimport()
        {
            return View();
        }
    }
}

