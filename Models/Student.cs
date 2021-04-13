using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netonweb.Models
{
    public class Student
    {
        public Student(int id, string name, int classId)
        {
            Id = id;
            Name = name;
            ClassId = classId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }


        public static Student NewStudent()
        {
            var Student = new Student(1, "Mark", 3);
            return Student;
        }

        public static List<Student> AllStudents()
        {
            List<Student> allstudents = new List<Student>();

            allstudents.Add(new Student(1, "Julio", 6));
            allstudents.Add(new Student(2, "Mark", 8));
            allstudents.Add(new Student(3, "Viktor", 6));
            allstudents.Add(new Student(4, "Alexandra", 8));
            allstudents.Add(new Student(5, "Micha", 8));
            allstudents.Add(new Student(6, "Thomas", 2));
            allstudents.Add(new Student(7, "Jens", 2));
            allstudents.Add(new Student(8, "Anton", 8));
            allstudents.Add(new Student(9, "Paul", 8));
            allstudents.Add(new Student(10, "Oscar", 6));
            allstudents.Add(new Student(11, "Nattaya", 6));
            allstudents.Add(new Student(12, "Laila", 2));
            return allstudents;
            }
    }
    }

