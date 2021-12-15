using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasFront.Models;

namespace UasFront.Services
{
    public interface IEnrollmentService
    {
        Task<Enrollment> GetById(int id);
    }
}