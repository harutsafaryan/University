using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Teacher
    {
        public Guid id;
        public string name;
        public string course;
        public Student[] students;

        public Teacher(string name, string course)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.course = course;
        }
    }
}
