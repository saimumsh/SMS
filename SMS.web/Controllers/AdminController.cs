using Microsoft.AspNetCore.Mvc;

namespace SMS.web.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
