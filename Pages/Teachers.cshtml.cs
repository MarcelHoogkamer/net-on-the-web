using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Netonweb.Models;

namespace Netonweb.Pages
{
    public class TeachersModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public Teacher teacher;
        public List<Teacher> teachers;


        public void OnGet()
        {
            Message = "the time is";
            teacher = Teacher.NewTeacher();
            teachers = Teacher.AllTeachers();
        }
    }
}
