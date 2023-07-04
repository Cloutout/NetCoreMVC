using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVC.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
