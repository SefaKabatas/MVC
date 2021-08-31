using System.Collections.Generic;

namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<People> _people = new List<People>();
        
        public static List<People> People{
            get{
                return _people;
            }
        }
        public static void Addpeople(People people){
            _people.Add(people);
        }

        
         
    }
}