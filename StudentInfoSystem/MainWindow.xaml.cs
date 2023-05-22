using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "";
            Surname.Text = "";
            Family_Name.Text = "";
            Faculty.Text = "";
            Specialty.Text = "";
            Qualification.Text = "";
            Status.Text = "";
            Fac__Number.Text = "";
            Course.Text = "";
            Group.Text = "";
            Stream2.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Name.IsEnabled)
            {
                Name.IsEnabled = false;
                Surname.IsEnabled = false;
                Family_Name.IsEnabled = false;
                Faculty.IsEnabled = false;
                Specialty.IsEnabled = false;
                Qualification.IsEnabled = false;
                Status.IsEnabled = false;
                Fac__Number.IsEnabled = false;
                Course.IsEnabled = false;
                Group.IsEnabled = false;
                Stream2.IsEnabled = false;
            }
            else
            {
                Name.IsEnabled = true;
                Surname.IsEnabled = true;
                Family_Name.IsEnabled = true;
                Faculty.IsEnabled = true;
                Specialty.IsEnabled = true;
                Qualification.IsEnabled = true;
                Status.IsEnabled = true;
                Fac__Number.IsEnabled = true;
                Course.IsEnabled = true;
                Group.IsEnabled = true;
                Stream2.IsEnabled = true;
            }
        }

        private Student Button_Click_2(object sender, RoutedEventArgs e)
        {
            Student student = new Student(Name.Text, Surname.Text,Family_Name.Text,Faculty.Text,Specialty.Text,Qualification.Text,
                Status.Text,Fac__Number.Text,int.Parse(Course.Text),int.Parse(Stream2.Text),int.Parse(Group.Text));

            Name.Text = "";
            Surname.Text = "";
            Family_Name.Text = "";
            Faculty.Text = "";
            Specialty.Text = "";
            Qualification.Text = "";
            Status.Text = "";
            Fac__Number.Text = "";
            Course.Text = "";
            Group.Text = "";
            Stream2.Text = "";

            return student;
        }
    }
}
