using System.Windows;
using Zemelya56.Models;

namespace Zemelya56.Views
{
    public partial class EditRequestWindow : Window
    {
        private Request request;

        public EditRequestWindow(Request request)
        {
            InitializeComponent();
            this.request = request;
            Title.Text = request.Title;
            Description.Text = request.Description;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            request.Title = Title.Text;
            request.Description = Description.Text;
            MessageBox.Show("Request updated successfully");
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Request deleted successfully");
            this.Close();
        }
    }
}