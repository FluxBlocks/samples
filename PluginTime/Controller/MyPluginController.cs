using Microsoft.AspNetCore.Mvc;

namespace PluginTime
{
    [Area("time")]
    public class MyPluginController : Controller
    {
        public IActionResult Index()
        {
            var p = new PluginTime();
            return View(p);
        }
    }
}
