using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart_Mirror.ViewModels;

namespace Smart_Mirror.Controllers
{
    public class PainterController : Controller
    {
        // GET: Painter
        public ActionResult Index()
        {
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
	        return View(viewModel);
		}

	    public ActionResult Intro()
	    {
		    HomeScreenViewModel viewModel = new HomeScreenViewModel();
		    return View(viewModel);
	    }
		public ActionResult PaintModule1()
	    {
		    HomeScreenViewModel viewModel = new HomeScreenViewModel();
		    return View(viewModel);
	    }
	    public ActionResult PaintModule2()
	    {
		    HomeScreenViewModel viewModel = new HomeScreenViewModel();
		    return View(viewModel);
	    }
	    public ActionResult Pantmodule3()
	    {
		    HomeScreenViewModel viewModel = new HomeScreenViewModel();
		    return View(viewModel);
	    }

	    public ActionResult PaintModulFinal()
	    {
		    HomeScreenViewModel viewmodel = new HomeScreenViewModel();
		    return View(viewmodel);
	    }
	    public ActionResult Outro()
	    {
		    HomeScreenViewModel viewModel = new HomeScreenViewModel();
		    return View(viewModel);
	    }


	}
}