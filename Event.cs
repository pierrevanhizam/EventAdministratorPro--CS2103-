using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentClass;
using VenueClass;
using System.IO;

namespace EventClass
{
    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; } 
        public string startTime { get; set; }
        public string endTime { get; set; } 
        public List<Student> guestList;
        public Venue venue { get; set; }
        public string organizerName { get; set; }
        public Student organizer { get; set; }
        public int capacity { get; set; }
        public int budget { get; set; }

        //contrustor used to load events from database
        public Event(int Id)
        {
            //some db function here?
        }

        //constructor used to create new event
        public Event(int Id, string Name, string Description, string StartDate, string EndDate, 
                     string StartTime, string EndTime, string VenueName, Student Organizer)
        {
            id = Id;
            name = Name;
            description = Description;
            startDate = StartDate;
            Venue v = new Venue(VenueName);
            venue = v;
            organizer = Organizer;
        }

        //for my own ad-hoc used to test the UI. can delete later.
        public Event(int Id, string Name, string Description, string StartDate, string OrganizerName)
        {
            id = Id;
            name = Name;
            description = Description;
            startDate = StartDate;
            organizerName = organizerName;
        }

        //Felix's
        public void saveToDb()
        {
            //something here
        }

        public void saveToFile()
        {
            StreamWriter sw = new StreamWriter("events.txt", true);
            sw.WriteLine(id);
            sw.WriteLine(name);
            sw.WriteLine(description);
            sw.WriteLine(startDate);
            sw.WriteLine(organizerName);
            sw.Close();
        }

    }
}
