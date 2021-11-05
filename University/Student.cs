using System;

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

        public void Print()
        {
            Console.WriteLine($"student name: {name}, age is: {age}, teacher is: {teacher.name}");
        }
    }

  

}
