using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasFront.Models;
using UasFront.Services;
using Microsoft.AspNetCore.Components;

namespace UasFront.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student(); 
        [Inject]
        public IStudentService StudentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task HandleValidSubmit()
        {
            Student result = await StudentService.Add(Student);
            NavigationManager.NavigateTo("/mahasiswa");
        }
    }
}