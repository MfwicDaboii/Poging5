using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Smart_Mirror.ViewModels;

namespace Smart_Mirror.Controllers
{
	
	public class HomeController : Controller
	{
		public ActionResult Index()
		{

			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		
	}
}