using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Teacher[] teachers = new Teacher[5];
            Student[] students = new Student[34];

            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"teacher_{i}", $"Course_{rnd.Next(1, 5)}");
            }

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"student_{i}", rnd.Next(12, 20));
            }

            University university = new University(students, teachers); //create university object with given students and teachers
            Student s8 = new Student("s8", 17); 
            university.Add(s8);
            university.Remove(students[4]);
            university.DistribStudents();

            //create students list for given teacher
            Student[] studentList = university.GetStudentsForTeacher(teachers[4]);
            foreach (var student in studentList)
            {
                student.Print();
            }

            Console.WriteLine();
        }
    }
}
