using Zemelya56.Models;
using Zemelya56.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Zemelya56.Services;
using Zemelya56.ViewModels;

namespace Zemelya56.ViewModels
{
    public class RequestViewModel : BaseViewModel
    {
        private RequestService requestService;

        public RequestViewModel()
        {
            requestService = new RequestService();
            CreateRequestCommand = new RelayCommand(CreateRequest);
            EditRequestCommand = new RelayCommand(EditRequest);
            DeleteRequestCommand = new RelayCommand(DeleteRequest);

            Requests = new ObservableCollection<Request>(requestService.GetRequestsByUserId(UserId));
        }

        private int userId;
        public int UserId
        {
            get { return userId; }
            set
            {
                userId = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Request> requests;
        public ObservableCollection<Request> Requests
        {
            get { return requests; }
            set
            {
                requests = value;
                OnPropertyChanged();
            }
        }

        private Request selectedRequest;
        public Request SelectedRequest
        {
            get { return selectedRequest; }
            set
            {
                selectedRequest = value;
                OnPropertyChanged();
            }
        }

        private string requestType;
        public string RequestType
        {
            get { return requestType; }
            set
            {
                requestType = value;
                OnPropertyChanged();
            }
        }

        private string requestDescription;
        public string RequestDescription
        {
            get { return requestDescription; }
            set
            {
                requestDescription = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreateRequestCommand { get; }
        public ICommand EditRequestCommand { get; }
        public ICommand DeleteRequestCommand { get; }

        private void CreateRequest()
        {
            var request = new Request
            {
                UserId = userId,
                Type = requestType,
                Status = "pending",
                Description = requestDescription
            };
            requestService.CreateRequest(request);
            Requests.Add(request);
        }

        private void EditRequest()
        {
            if (selectedRequest != null)
            {
                selectedRequest.Type = requestType;
                selectedRequest.Status = "pending";
                selectedRequest.Description = requestDescription;
                requestService.EditRequest(selectedRequest);
            }
        }

        private void DeleteRequest()
        {
            if (selectedRequest != null)
            {
                requestService.DeleteRequest(selectedRequest.Id);
                Requests.Remove(selectedRequest);
            }
        }
    }
}