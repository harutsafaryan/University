using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class University
    {
        public Student[] students;
        public Teacher[] teachers;
        public int[,] releathions; //matrix wich represent teachers and students relathions

        public University(Student[] students, Teacher[] teachers)
        {
            this.students = students;
            this.teachers = teachers;
            releathions = new int[students.Length, teachers.Length];
            
        }

        /// <summary>
        /// Add given student to students 
        /// </summary>
        /// <param name="student">Given student</param>
        public void Add(Student student)
        {
            students.Append(student);
        }

        /// <summary>
        /// Add given teacher to teachers
        /// </summary>
        /// <param name="teacher"></param>
        public void Add(Teacher teacher)
        {
            teachers.Append(teacher);
        }

        /// <summary>
        /// Distrib students by classes to teachers
        /// </summary>
        /// <param name="classes">Given namber of classes</param>
        public void DistribStudents()
        {
            for (int i = 0; i < students.Length; i ++)
            {
                releathions[i, (i+i*teachers.Length) % teachers.Length] = 1;
            }
        }

        public void Print()
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < teachers.Length; j++)
                {
                    Console.Write(releathions[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Student[] GetStudentsForteacher(Teacher teacher)
        {
            int index=0;
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teacher.Equals(teachers[i]))
                    index = i;
            }

            Student[] result = new Student[0];
            for (int i = 0; i < students.Length; i++)
            {
                if (releathions[i, index] == 1)
                    result.Append(students[i]);
            }

            return result;
        }
    }
}
