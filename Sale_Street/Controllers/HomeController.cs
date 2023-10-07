using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Sale_Street.Models;

namespace Sale_Street.Controllers
{
	[AllowAnonymous]
	public class HomeController:Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly MyContext _context;

		public HomeController(ILogger<HomeController> logger , MyContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products.Take(10).ToList(); 
			return View(products);
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
