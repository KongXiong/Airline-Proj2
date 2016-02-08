using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Airline_proj
{
    class GoogleCalendar
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public int[] FDate()
        {
            Console.WriteLine("Enter Final date:");
            string read2 = Console.ReadLine();
            int[] sdate2 = read2.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
            return sdate2;
        }

        public string UserEmail()
        {
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            return email;
        }

        public void AddEvent()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart");

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
                ApplicationName = ApplicationName,
            });
            Console.WriteLine("Enter sumary");
            string sum = Console.ReadLine();

            Console.WriteLine("Enter Location");
            string location = Console.ReadLine();

            Event myEvent = new Event
            {

                Summary = sum,
                Location = location,
                Start = new EventDateTime()
                {
                    DateTime = new DateTime(2016,03,06),
                    TimeZone = "America/Chicago"
                },
                End = new EventDateTime()
                {
                    DateTime = new DateTime(2016,03,07),
                    TimeZone = "America/Chicago"
                },
                Recurrence = new String[] {
      "RRULE:FREQ=WEEKLY;BYDAY=MO"
  },
                Attendees = new List<EventAttendee>()
      {
        new EventAttendee() { Email = "johndoe@gmail.com" }
      }
            };

            Event recurringEvent = service.Events.Insert(myEvent, "primary").Execute();
        }
    }
}