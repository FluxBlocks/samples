using Microsoft.AspNetCore.Mvc;
using PluginHRServices;

namespace PluginHR
{
    public class Foo
    {
        public string Name { get; set; }
    }
    [Area("hr")]
    public class MyPluginController : Controller
    {
        private ITest _test { get; set; }
        public MyPluginController(ITest Test)
        {
            _test = Test;
        }
        public ActionResult Testing()
        {
            var s = _test.TestTest();
            var f = new Foo();
            f.Name = s;
            return View(f);
        }
        public ActionResult Index()
        {
            var p = new PluginHR();            
            return View(p);
        }
    }
}
