using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher t1 = new Teacher("Jane", "english");
            Teacher t2 = new Teacher("Jesika", "mathematics");
            Teacher t3 = new Teacher("Nency", "physics");

            Student s1 = new Student("s1", 10);
            Student s2 = new Student("s2", 11);
            Student s3 = new Student("s3", 12);
            Student s4 = new Student("s4", 13);
            Student s5 = new Student("s5", 14);
            Student s6 = new Student("s6", 15);
            Student s7 = new Student("s7", 16);

            Student[] students = new Student[] { s1, s2, s3, s4, s5, s6, s7 };
            Teacher[] teachers = new Teacher[] { t1, t2, t3 };

            University university = new University(students, teachers);
            university.Distribution();
            Console.WriteLine();
        }
    }
}
