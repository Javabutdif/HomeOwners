using Microsoft.AspNetCore.Mvc;

namespace HomeOwner.Controllers
{
    public class Homeowner : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
