using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projecto_Jo_.Models;

namespace Projecto_Jo_.Controllers.home
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> _logger)
		{
			_logger = _logger;
		}

	//	public IActionResult Index()  esto todavia no lo vamos a usar ;)
	//	{
	//		var itemsParaHome = HomeController._menu.TakeLast(3).ToList();
	//		return View(itemsParaHome);
	//	} //

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
