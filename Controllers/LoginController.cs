using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

    [Route("Login")] 

    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}

