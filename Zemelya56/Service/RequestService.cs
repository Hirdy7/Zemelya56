using Zemelya56.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Zemelya56.Services
{
    public class RequestService
    {
        private List<Request> requests;
        private readonly string filePath = "requests.json";

        public RequestService()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                requests = JsonConvert.DeserializeObject < List < Request>>(json);
            }
            else
            {
                requests = new List<Request>();
            }
        }

        public void CreateRequest(Request request)
        {
            request.Id = requests.Any() ? requests.Max(r => r.Id) + 1 : 1;
            requests.Add(request);
            SaveToFile();
        }

        public void EditRequest(Request request)
        {
            var existingRequest = requests.FirstOrDefault(r => r.Id == request.Id);
            if (existingRequest != null)
            {
                existingRequest.Type = request.Type;
                existingRequest.Status = request.Status;
                existingRequest.Description = request.Description;
                SaveToFile();
            }
        }

        public void DeleteRequest(int requestId)
        {
            var request = requests.FirstOrDefault(r => r.Id == requestId);
            if (request != null)
            {
                requests.Remove(request);
                SaveToFile();
            }
        }

        public List<Request> GetRequestsByUserId(int userId)
        {
            return requests.Where(r => r.UserId == userId).ToList();
        }

        private void SaveToFile()
        {
            var json = JsonConvert.SerializeObject(requests, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
