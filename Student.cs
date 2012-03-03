using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventClass;

namespace StudentClass
{
    public class Student
    {
        public int id { get; set; } //id in dabatase?
        public string userId { get; set; } //matric number?
        public string name { get; set; }
        public string password { get; set; }
        //not sure which one is better to use in term of efficiency.
        public List<Event> registeredEvents { get; set; }
        public List<Event> organizedEvents { get; set; }
        public List<int> registeredEventsId { get; set; }
        public List<int> organizedEventsId { get; set; }
        
        public Student(string UserId, string Password)
        {
            userId = UserId;
            password = Password;
        }

        public void createEvent(int Id, string Name, string Description, string StartDate)
        {
            Event ev = new Event(Id, Name, Description, StartDate, this.userId);
            ev.saveToFile();
        }

        //public void register(Event e);
        //public void deregister(Event e);

    }
}
