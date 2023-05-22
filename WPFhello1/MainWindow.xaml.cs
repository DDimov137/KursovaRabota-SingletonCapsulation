using System;
using System.Collections.Generic;
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

namespace WPFhello1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ListBoxItem item = new ListBoxItem();
            ///item.Content = "Leona";
            // peopleList.Items.Add(item);
            //ListBoxItem item1 = new ListBoxItem();
            //item.Content = "David";
            //peopleList.Items.Add(item1);
            //.SelectedItem = item;
            //string person = (peopleList.SelectedItem as ListBoxItem).Content.ToString();
            //MessageBox.Show("Hi" + person); ListBoxItem james = new ListBoxItem(); 
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            james.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;


            //
        }



        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здрасти!!! Това е твоята първа програма на Visual Studio 2012!");
        }

        private void peopleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }
    }
}
