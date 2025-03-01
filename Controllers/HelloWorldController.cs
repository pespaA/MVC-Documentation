using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        // Get: http://localhost:5211/Helloworld/Welcome?name=Omar&numtimes=2525
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method...";
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, ID: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        public string test()
        {
            return "testetsetsetsetsetsetsets";
        }
    }
}
