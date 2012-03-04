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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using EventClass;
using StudentClass;

namespace EMP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Event> eventList = new ObservableCollection<Event>();

        public MainWindow()
        {
            //this.importEvents
            this.importEventsFromFile();
            InitializeComponent();
        }

        public ObservableCollection<Event> EventList
        {
            get { return this.eventList; }
        }
        
        //import event from database
        public void importEvents()
        {
        }
        
        private void importEventsFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader("events.txt");
                bool makePublic = true;
                while (!sr.EndOfStream)
                {
                    int id = Convert.ToInt16(sr.ReadLine());
                    string name = sr.ReadLine();
                    string description = sr.ReadLine(); 
                    string startDate = sr.ReadLine();
                    string organizerName = sr.ReadLine();
                    
                    Event i = new Event(id, name, description, startDate, organizerName, makePublic);
                    this.EventList.Add(i);
                }
            }
            catch (IOException e)
            {
                //display some error message
                Console.WriteLine(e);
            }
        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            if (login(userIdBox.Text, passwordBox.Password))
            {
                Student s = new Student(userIdBox.Text, passwordBox.Password);
                EventListWindow window = new EventListWindow();
                window.student = s;
                window.Show();
                this.Close();
            }
            else
                errorLabel.Visibility = Visibility.Visible;
        }

    }
}
