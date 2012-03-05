using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using StudentClass;
using EventClass;

namespace EMP
{
    /// <summary>
    /// Interaction logic for EventsScreen.xaml
    /// </summary>
    public partial class EventsScreen : Page
    {
		private List<Event> _upcomingEventsList;
		
        public EventsScreen()
        {
            InitializeComponent();
			
			// Generate 'Upcoming Events' from flat file for now.
			this._upcomingEventsList = new List<Event>();
			this.ImportEventsFromFile();
			this.upcomingEventsListGrid.ItemsSource = this._upcomingEventsList;
        }
		
		// Import events from flat-file (events.txt).
		private void ImportEventsFromFile()
		{
			try
			{
				StreamReader sr = new StreamReader("events.txt");
				while (!sr.EndOfStream)
				{
					int id = Convert.ToInt16(sr.ReadLine());
                    string name = sr.ReadLine();
                    string description = sr.ReadLine(); 
                    string startDate = sr.ReadLine();
                    string organizerName = sr.ReadLine();
					
					Event i = new Event(id, name, description, startDate, organizerName);
                    this._upcomingEventsList.Add(i);
				}
			}
			catch (IOException e)
            {
                // Display error message.
                Console.WriteLine(e);
            }
		}
    }
}
