using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Netonweb.Models;

namespace Netonweb.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public Student student;
        public List<Student> students;
        

        public void OnGet()
        {
            Message = "the time is";
            student = Student.NewStudent();
            students = Student.AllStudents(); 
        }
        }
}




