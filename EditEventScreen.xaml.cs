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
    /// Interaction logic for EditEventsScreen.xaml
    /// </summary>
    public partial class EditEventScreen : Page
    {
        public EditEventScreen()
        {
            InitializeComponent();
			
			// Set the title according to current action (Edit or Add).
			this.Title = "Create Event";
        }
    }
}
