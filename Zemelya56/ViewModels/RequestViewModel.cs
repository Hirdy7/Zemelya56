using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Zemelya56.Models;
using Zemelya56.Service;

namespace Zemelya56.ViewModels
{
    public class RequestViewModel : INotifyPropertyChanged
    {
        private RequestService requestService;
        private ObservableCollection<Request> requests;

        public RequestViewModel()
        {
            requestService = new RequestService();
            LoadRequests();
        }

        public ObservableCollection<Request> Requests
        {
            get { return requests; }
            set
            {
                requests = value;
                OnPropertyChanged("Requests");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadRequests()
        {
            Requests = new ObservableCollection<Request>(requestService.GetAllRequests());
        }

        public void AddRequest(Request request)
        {
            requestService.AddRequest(request);
            LoadRequests();
        }

        public void UpdateRequest(Request request)
        {
            requestService.UpdateRequest(request);
            LoadRequests();
        }

        public void DeleteRequest(string title)
        {
            requestService.DeleteRequest(title);
            LoadRequests();
        }
    }
}