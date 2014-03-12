using ReallySimpleCli.ActionResults;
using ReallySimpleCli.Controllers;
using ReallySimpleCli.TestApp.Models;

namespace ReallySimpleCli.TestApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Get()
        {
            var model = new DefaultModel();

            return new ViewResult(model);
        }

        public IActionResult Post()
        {
            return null;
        }
    }
}