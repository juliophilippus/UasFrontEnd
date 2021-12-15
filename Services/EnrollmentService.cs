using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UasFront.Models;

namespace UasFront.Services
{
    public class EnrollmentService : IEnrollmentService
    { 
        private HttpClient _httpClient;
        
        public EnrollmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Enrollment> GetById(int id)
        {
            var results = await _httpClient.GetFromJsonAsync<Enrollment>($"api/enrollment/{id}");
            return results;
        }
    }
}