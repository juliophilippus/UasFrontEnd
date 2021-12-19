using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UasFront.Models;
using UasFront.Services;

namespace UasFront.Pages
{
    public partial class StudentPage
    {
        public List<Student> Students { get; set; } = new List<Student>();
        [Inject]
        public IStudentService StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentService.GetAll()).ToList();
        }

    }
}