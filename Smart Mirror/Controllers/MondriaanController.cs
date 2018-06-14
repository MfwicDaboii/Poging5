using Smart_Mirror.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart_Mirror.Controllers
{
    public class MondriaanController : Controller
    {
		// GET: Mondriaan
		public ActionResult Index()
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
	    public ActionResult Paintmodule3()
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
	    public ActionResult Vraag()
	    {
		    HomeScreenViewModel viewModel = new HomeScreenViewModel();
		    return View(viewModel);
	    }
	}
}