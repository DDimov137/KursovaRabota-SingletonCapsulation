using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        public String name;
        public String surname;
        public String familyName;
        public String faculty;
        public String specialty;
        public String qualification;
        public String status;
        public String facNum;
        public int course;
        public int stream;
        public int group;
        public int StudentId { get; set; }

        public Student(String name, String surname, String familyName, String faculty,
            String specialty, String qualification, String status, String facNum,
            int course, int stream, int group)
        {
            this.name = name;
            this.surname = surname;
            this.familyName = familyName;
            this.faculty = faculty;
            this.specialty = specialty;
            this.qualification = qualification;
            this.status = status;
            this.facNum = facNum;
            this.course = course;
            this.stream = stream;
            this.group = group;
        }

    }
}
