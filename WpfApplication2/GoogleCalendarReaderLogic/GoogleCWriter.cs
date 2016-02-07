﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleCalendarReaderLogic
{
    public class GoogleCWriter
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        //public List<string> gcevents = new List<string>();
        //public List<string> dates = new List<string>();

        public void GoogleMainWriter(string sumary, string airplaneId,string location, DateTime start, DateTime finish)
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

            Event myEvent = new Event
            {
                Summary = sumary,
                Location = location,
                Start = new EventDateTime()
                {
                    DateTime = start,
                    TimeZone = "America/Los_Angeles"
                },
                End = new EventDateTime()
                {
                    DateTime = finish,
                    TimeZone = "America/Los_Angeles"
                },
                Recurrence = new String[] {
                  "RRULE:FREQ=WEEKLY;BYDAY=MO"
              },
                Attendees = new List<EventAttendee>()
                  {
                    new EventAttendee() { Email = "johndoe@gmail.com" }
                  }
            };

            Event recurringEvent = service.Events.Insert(myEvent, airplaneId).Execute();
        }
    }
}


            // Define parameters of request.
            /////////////////////////////////////////////////////////////////
            //EventsResource.ListRequest request = service.Events.List("primary");
            //request.TimeMin = DateTime.Now;
            //request.ShowDeleted = false;
            //request.SingleEvents = true;
            //request.MaxResults = 10;
            //request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            //// List events.
            //Events events = request.Execute();

            ////Console.WriteLine("Upcoming events:");
            //if (events.Items != null && events.Items.Count > 0)
            //{
            //    foreach (var eventItem in events.Items)
            //    {
            //        string when = eventItem.Start.DateTime.ToString();
            //        if (String.IsNullOrEmpty(when))
            //        {
            //            when = eventItem.Start.Date;
            //        }
            //        //Console.WriteLine("{0} ({1})", eventItem.Summary, when);
            //        gcevents.Add(eventItem.Summary);
            //        dates.Add(when);
            //    }
            //}
            //else
//            {
//                //Console.WriteLine("No upcoming events found.");
//            }
//            // Console.Read();



//        }
//    }
//}
//}