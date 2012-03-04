using System;
using System.Collections.Generic;
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
using EventClass;

namespace EMP
{
	public partial class LoginScreen
	{
		private List<Event> _upcomingEventsList;
		
		public LoginScreen()
		{
			this.InitializeComponent();
			
			// Generate 'Upcoming Events' from flat file for now.
			this._upcomingEventsList = new List<Event>();
			this.ImportEventsFromFile();
			this.upcomingEventsListBox.ItemsSource = this._upcomingEventsList;
		}
		
		// Method for getting events from DB.
		private void GetUpcomingEvents(string startDate, int startIndex, int number)
		{
			// TODO: Get events based on startDate and return x number of events starting from startIndex.
		}
		
		// Method to validate user login information.
		private void ValidateUser(string username, string password)
		{
			// TODO: Search for existing user information from database.
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
		
		// Event handler for getting more events from DB.
		private void UpcomingEventsFilter_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			// TODO: Get events based on selected month.
		}
		
		// Event handler for 'Previous' button.
		private void PrevButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Get events from the previous month.
		}

		// Event handler for 'Next' button.
		private void NextButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Get events from the next month.
		}
		
		// Event handler when user clicks on 'Login' button.
		private void LoginButton_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Validate user login information.
			this.loginLoadingPanel.Visibility = Visibility.Visible;
		}
	}
}