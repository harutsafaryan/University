using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public Guid id;
        public string name;
        public int age;
        public Teacher teacher;

        public Student(string name, int age)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.age = age;
        }
    }
}
