using Microsoft.AspNetCore.Mvc;


namespace CentralDuplicatas.Controllers
{

    [Route("Dashboard")] 

    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

