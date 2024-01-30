using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;

        public FirstController(ILogger<FirstController> logger)
        {
            _logger = logger;
        }


        public string Index() {

            _logger.LogInformation("Index Action");
            Console.WriteLine("Index Action");
            return "Toi la Index cua First";
        }
    }
}
