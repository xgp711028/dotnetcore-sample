using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorial.Web.Models;
using Tutorial.Web.Services;

namespace Tutorial.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IRepository<Student> _repository;

		public HomeController(IRepository<Student> repository)
		{
			_repository = repository;
		}

		public IActionResult Index()
		{
			var list = _repository.GetAll();
			return View(list);
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
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
