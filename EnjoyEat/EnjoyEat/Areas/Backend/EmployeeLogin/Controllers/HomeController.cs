using Microsoft.AspNetCore.Mvc;

namespace EnjoyEat.Areas.Backend.EmployeeLogin.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
