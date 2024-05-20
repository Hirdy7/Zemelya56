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
using System.Windows.Shapes;

namespace Zemelya56
{
    /// <summary>
    /// Логика взаимодействия для regWindow.xaml
    /// </summary>
    public partial class regWindow : Window
    {
        public regWindow()
        {
            InitializeComponent();
        }

        private void btnauth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow auth = new MainWindow();
            auth.Show();
            this.Close();
        }
    }
}
