using dugundavet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dugundavet;
namespace dugundavet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Cevap_Formu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Cevap_Formu(Cevap User_Reply)
        {
            //buradaki if ve else bloklarını koymamızın sebebi doğruysa thanks kısmını döndür, yanlışsa viewi boş döndür. modelstate.isvalid = doğru mu anlamına gelir.
            if (ModelState.IsValid)
            {
                Repository.Cevapekle(User_Reply);  // bu method ile formdan gelen verileri saklıyoruz.
                return View("Thanks", User_Reply);
            }
            else
            {
                return View(); 
            }
        }
        public ViewResult List_answers()
        {
            return View(Repository.Cevaplar.Where(x => x.WillYouJoin == true));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
