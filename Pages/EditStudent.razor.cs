using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasFront.Models;
using UasFront.Services;
using Microsoft.AspNetCore.Components;

namespace UasFront.Pages
{
    public partial class EditStudent
    {
        public Student Student { get; set; } = new Student(); 
        [Inject]
        public IStudentService StudentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Student = await StudentService.GetById(int.Parse(Id));
        }

        protected async Task HandleValidSubmit()
        {
            var result = await StudentService.Update(int.Parse(Id),Student);
            NavigationManager.NavigateTo("/mahasiswa");
        }
    }
}