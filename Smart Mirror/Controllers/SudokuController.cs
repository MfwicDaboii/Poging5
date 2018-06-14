using Smart_Mirror.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart_Mirror.Controllers
{
	public class SudokuController : Controller
	{
		
		public ActionResult SudokuModule()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}

		public ActionResult SudokuModule2()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}
		public ActionResult SudokuModule3()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}
		public ActionResult SudokuModule4()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}
		public ActionResult SudokuModule5()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}
		public ActionResult SudokuModule6()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}
		public ActionResult SudokuModule7()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}

		public ActionResult InteresseSudoku()
		{
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			return View(viewModel);
		}

	}
}