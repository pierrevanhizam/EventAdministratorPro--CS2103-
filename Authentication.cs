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
    public partial class MainWindow : Window
    {
        //To do: connect to database and search to see whether match
        //right now: check against textfile
        public bool login(string userId, string password)
        {
            try
            {
                StreamReader sr = new StreamReader("users.txt"); //username: asdf password: asdf should work
                while (!sr.EndOfStream)
                {
                    string UserId = sr.ReadLine();
                    string Password = sr.ReadLine();

                    if (userId == UserId)
                    {
                        if (password == Password)
                        {
                            return true;
                        }
                       
                        else return false;
                    }
                }
                return false;
                
            }
            catch (IOException e)
            {
                //display some error message
            }

            return false;
        }
    }
}
