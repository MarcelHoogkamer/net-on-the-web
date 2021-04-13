using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Netonweb.Models;

namespace Netonweb.Pages
{
    public class ClassRoomModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public ClassRoom SingleClass;
        public List<ClassRoom> AllClasses;


        public void OnGet()
        {
            Message = "the time is";
            SingleClass = ClassRoom.SingleClass();
            AllClasses = ClassRoom.AllClasses();
        }
    }
}
