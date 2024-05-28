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
using Zemelya56.Views;

namespace Zemelya56
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

        private void OpenLoginWindow(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginView();
            loginWindow.Show();
        }

        private void OpenRequestWindow(object sender, RoutedEventArgs e)
        {
            var RequestWindow = new RequestView();
            RequestWindow.Show();
        }
    }
}
