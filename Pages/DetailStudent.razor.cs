using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UasFront.Models;
using UasFront.Services;
using Microsoft.AspNetCore.Components;

namespace UasFront.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
        public string id { get; set; }
        [Inject]
        public IStudentService StudentService { get; set; }
        public Student Student { get; set; } = new Student();
        
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(int.Parse(id));
        }
    }
}