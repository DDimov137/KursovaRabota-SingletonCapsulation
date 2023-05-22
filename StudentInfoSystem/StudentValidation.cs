using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public static Student getStudentDataByUser(User user)
        {
            Student student = (from stud in StudentData.testStudents where stud.facNum.Equals(user.facNum)
                               select stud).First();
            if(student == null)
            {
                Console.WriteLine("Student not found");
            }
            return student;
        }
    }
}
