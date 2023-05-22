using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        public static List<Student> testStudents
        {
            get 
            {
                change();
                return testStudents;
            }
            private set { }
        }
        
        private static void change()
        {
            if (testStudents == null)
            {
                testStudents.Add(new Student("1", "1", "1", "1", "1", "1", "1", "1", 1, 1, 1));
                testStudents.Add(new Student("2", "2", "2", "2", "2", "2", "2", "2", 2, 2, 2));
                testStudents.Add(new Student("3", "3", "3", "3", "3", "3", "3", "3", 3, 3, 3));

            }
        }
    }
}
