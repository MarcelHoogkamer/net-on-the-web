using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netonweb.Models
{
    public class Teacher
    {
        public Teacher(int id, string name, int classId)
        {
            Id = id;
            Name = name;
            ClassId = classId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }


 public static Teacher NewTeacher()
    {
        var Teacher = new Teacher(1, "Koen", 6);
        return Teacher;
    }

    public static List<Teacher> AllTeachers()
    {
        List<Teacher> allteachers = new List<Teacher>();

        allteachers.Add(new Teacher(1, "Koen", 6));
        allteachers.Add(new Teacher(2, "Tim", 8));
        allteachers.Add(new Teacher(3, "Sicco", 2));
        return allteachers;
    }
    }

}
