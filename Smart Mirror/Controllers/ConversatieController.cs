using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart_Mirror.ViewModels;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace Smart_Mirror.Controllers
{
	public class ConversatieController : Controller
	{
		// GET: Conversatie
		public ActionResult Index()
		{
			int x = 0;
			HomeScreenViewModel viewModel = new HomeScreenViewModel();
			
			if (Session["positie"] == null)
			{
				Session["positie"] = 0;

			}
			x = Convert.ToInt32(Session["positie"]);
			switch (x)
			{
				case 0:
					viewModel.Tekst= "Goeie avond Harm. Hoe was je dag vandaag?";
					break;
				case 1:
					viewModel.Tekst = "Heb je zoveel gedaan vandaag dan?";
					break;
				case 2:
					viewModel.Tekst = "Ow dat is zeer jammer om te horen \n " +
					                    "Ik heb gehoord dat na een lange dag, een kop koffie wonderen doet";
					break;
				case 3:
					viewModel.Tekst = "Hey Harm heb je toevallig de uitslagen van alle wedstrijden gezien vandaag";
					break;
				case 4:
					viewModel.Tekst = "Wow weer een El CLassico. Wil je anders ook de uitslagen van alle andere wedstrijden?";
					break;
				case 5:
					viewModel.Tekst = "Ow harm ik bedacht me net dat de Jupiler League binnerkort is. \n" +
					                    "Zal ik dit in je agenda zetten anders";
					break;
			}

			x++;
			Session["positie"] = x;
			
			return View(viewModel);
		}

		[HttpPost]
		public async Task<ActionResult> TTS(string text)
		{
			// you can set output file name as method argument or generated from text
			string fileName = "TestPraten";
			if (text == null || text == "")
			{
				text = "Hii im deafult text";
			}
			Task<ViewResult> task = Task.Run(() =>
			{
				using (SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer())
				{
					speechSynthesizer.SetOutputToWaveFile(Server.MapPath("~/Content") + fileName + ".wav");
					speechSynthesizer.Speak(text);

					ViewBag.FileName = fileName + ".wav";
					return View();
				}
			});
			return await task;
		}
	}
}