using Microsoft.AspNetCore.Mvc;

namespace CentralDuplicatas.Controllers
{
    [Route("Certificado")] 

    public class CertificateController : Controller
    {
        
        public IActionResult Certificate()
        {
            return View();
        }
       
     
    }
}