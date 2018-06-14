using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Smart_Mirror.Models;

namespace Smart_Mirror.ViewModels
{
	public class HomeScreenViewModel
	{
		public DateTime CurrentDay = DateTime.Today;
		public DateTime CurrentTime = DateTime.Now;
		public string Tekst { get; set; }
		static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
		public string ReturnMonth(int month)
		{
			string answer = "";
			switch (month)
			{
				case 1:
					answer = MonthConverter.Jan.ToString();
					break;
				case 2:
					answer = MonthConverter.Feb.ToString();
					break;
				case 3:
					answer = MonthConverter.Ma.ToString();
					break;
				case 4:
					answer = MonthConverter.Apr.ToString();
					break;
				case 5:
					answer = MonthConverter.Mei.ToString();
					break;
				case 6:
					answer = MonthConverter.Jun.ToString();
					break;
				case 7:
					answer = MonthConverter.Jul.ToString();
					break;
				case 8:
					answer = MonthConverter.Aug.ToString();
					break;
				case 9:
					answer = MonthConverter.Okt.ToString();
					break;
				case 10:
					answer = MonthConverter.Nov.ToString();
					break;
				case 11:
					answer = MonthConverter.Dec.ToString();
					break;
				case 12:
					answer = MonthConverter.Jan.ToString();
					break;
			}
			return answer;
		}
		public IEnumerable<string> GetAgenda()
		{
			List<string> AlleEvents = new List<string>();
			UserCredential credential;
			using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
			{
				string credPath = System.Environment.GetFolderPath(
					System.Environment.SpecialFolder.Personal);
				credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

				credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
					GoogleClientSecrets.Load(stream).Secrets,
					Scopes,
					"user",
					CancellationToken.None,
					new FileDataStore(credPath, true)).Result;
				Console.WriteLine("Credential file saved to: " + credPath);
			}
			// Create Google Calendar API service.
			var service = new CalendarService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = "Smart Mirror",
			});

			// Define parameters of request.
			EventsResource.ListRequest request = service.Events.List("primary");
			request.TimeMin = DateTime.Now;
			request.ShowDeleted = false;
			request.SingleEvents = true;
			request.MaxResults = 10;
			request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

			//List of events
			Events events = request.Execute();
			if (events.Items != null && events.Items.Count > 0)
			{
				foreach (var eventItem in events.Items)
				{
					string when = eventItem.Start.DateTime.ToString();
					if (String.IsNullOrEmpty(when))
					{
						when = eventItem.Start.Date;
					}
					string dateOnly =when.Substring(0,when.IndexOf(":")-2) ;
					AlleEvents.Add(eventItem.Summary + " " + dateOnly);
				}
			}

			return AlleEvents;

		}

		public string GiveFeedbackSudoku()
		{
			DateTime startPoint = DateTime.Now;
			string feedback = "";
			if (startPoint.Minute == startPoint.Minute + 20)
			{
				feedback = "Hey Harm tnx voor je hulp, heb een 9 gekregen van mn leraar";
			}
			return feedback;
		}
		public string RandomGreeter()
		{
			Random rnd = new Random();
			string Greetings = "";
			
			switch (rnd.Next(1, 5))
			{
				case 1:
					Greetings = "heyy there sexy";
					break;
				case 2:
					Greetings = "Good morning handsome";
					break;
				case 3:
					Greetings = "Greetings summoner!";
					break;
				case 4:
					Greetings = "FOR DEMACIA!!";
					break;
			}


			return Greetings;
		}

	}
}