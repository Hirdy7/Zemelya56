using System.Collections.Generic;
using Zemelya56.Models;
using System.Linq;
using System;

namespace Zemelya56.Service
{
    public class RequestService
    {
        private List<Request> requests = new List<Request>();

        public List<Request> GetAllRequests()
        {
            return requests;
        }

        public Request GetRequest(string title)
        {
            return requests.FirstOrDefault(r => r.Title == title);
        }

        public void AddRequest(Request request)
        {
            requests.Add(request);
        }

        public void UpdateRequest(Request updatedRequest)
        {
            var request = GetRequest(updatedRequest.Title);
            if (request != null)
            {
                request.Description = updatedRequest.Description;
                request.CreatedAt = updatedRequest.CreatedAt;
            }
        }

        public void DeleteRequest(string title)
        {
            var request = GetRequest(title);
            if (request != null)
            {
                requests.Remove(request);
            }
        }

        internal void CreateRequest(Request request)
        {
            throw new NotImplementedException();
        }
    }
}