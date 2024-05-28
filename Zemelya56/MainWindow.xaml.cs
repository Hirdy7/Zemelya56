using System;
using System.Windows;
using Zemelya56.Models;
using Zemelya56.ViewModels;
using Zemelya56.Views;

namespace Zemelya56
{
    public partial class MainWindow : Window
    {
        private RequestViewModel requestViewModel;

        public MainWindow()
        {
            InitializeComponent();
            requestViewModel = new RequestViewModel();
            DataContext = requestViewModel;
        }

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            var newRequest = new Request
            {
                Title = "New Request",
                Description = "Description",
                CreatedAt = DateTime.Now
            };
            requestViewModel.AddRequest(newRequest);
        }

        private void EditRequest_Click(object sender, RoutedEventArgs e)
        {
            if (RequestsList.SelectedItem is Request selectedRequest)
            {
                var editWindow = new EditRequestWindow(selectedRequest);
                editWindow.ShowDialog();
                requestViewModel.UpdateRequest(selectedRequest);
            }
        }

        private void DeleteRequest_Click(object sender, RoutedEventArgs e)
        {
            if (RequestsList.SelectedItem is Request selectedRequest)
            {
                requestViewModel.DeleteRequest(selectedRequest.Title);
            }
        }
    }
} 