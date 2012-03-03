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
using System.Diagnostics;
using StudentClass;
using EventClass;
using System.IO;

namespace EMP
{
    /// <summary>
    /// Interaction logic for AddEventWindow.xaml
    /// </summary>
    public partial class AddEventWindow : Window
    {
        public AddEventWindow()
        {
            InitializeComponent();
        }

        public Student student { get; set; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            student.createEvent(1, eventNameBox.Text, descriptionBox.Text, datePicker.Text);
            EventListWindow window = new EventListWindow();
            window.student = student;
            window.Show();
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            EventListWindow window = new EventListWindow();
            window.student = student;
            window.Show();
            this.Close();
        }




    }
}
