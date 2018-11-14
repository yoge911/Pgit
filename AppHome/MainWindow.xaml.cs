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
using AppHome.Controllers;
using System.Diagnostics;

namespace AppHome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BusinessTool BIApp;        

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                BusinessTool BIApp = new BusinessTool();
                //this.AppsListBox.ItemsSource = BIApp._businessApplications;

              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void App_Button_click(object sender, RoutedEventArgs e)
        {
            string selected_app = ((Button)sender).Tag.ToString();
            Process.Start(selected_app);
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
