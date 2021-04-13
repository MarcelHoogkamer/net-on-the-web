using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netonweb.Models
{
    public class ClassRoom
    {
        public ClassRoom(int classId, string name)
        {
            ClassId = classId;
            Name = name;
        }

        public int ClassId { get; set; }
        public string Name { get; set; }

        public static ClassRoom SingleClass()
        {
            var Room = new ClassRoom(2, "Lamarr");
            return Room;
        }

        public static List<ClassRoom> AllClasses()
        {
            List<ClassRoom> allclasses = new List<ClassRoom>();

            allclasses.Add(new ClassRoom(2, "Lamarr"));
            allclasses.Add(new ClassRoom(6, "Giertz"));
            allclasses.Add(new ClassRoom(8, "Hypatia"));
  
            return allclasses;
        }

    }
}
