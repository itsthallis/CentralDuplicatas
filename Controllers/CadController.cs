using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

    [Route("Cadastro")] 

    public class CadController : Controller
    {
        // public IActionResult Cad()
        // {
        //     return View();
        // }
         public IActionResult CadJuridico()
        {
            return View();
        }
    }
}

