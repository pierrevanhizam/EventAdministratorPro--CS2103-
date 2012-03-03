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
    /// Interaction logic for EventListWindow.xaml
    /// </summary>
    public partial class EventListWindow : Window
    {
        private ObservableCollection<Event> eventList = new ObservableCollection<Event>();

        public EventListWindow()
        {
            this.importEventsFromFile();
            InitializeComponent();
        }

        public ObservableCollection<Event> EventList
        {
            get { return this.eventList; }
        }

        public Student student { get; set; }
        
        private void importEventsFromFile()
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
                    this.EventList.Add(i);
                }
            }
            catch (IOException e)
            {
                //display some error message
                Console.WriteLine(e);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AddEventWindow window = new AddEventWindow();
            window.student = this.student;
            window.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

    }
}
