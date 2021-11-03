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

        public University(Student[] students, Teacher[] teachers)
        {
            this.students = students;
            this.teachers = teachers;
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
        /// Distrib students by by classes to teachers
        /// </summary>
        /// <param name="classes">Given namber of classes</param>
        public void Distribution()
        {
            //for (int i = 0; i < teachers.Length; i++)
            //    for (int j = i; j < students.Length; j += teachers.Length)
            //    {
            //        teachers[i].students[j] = students[j];
            //    }

            for (int i = 0; i < students.Length; i++)
            {
                students[i].teacher = teachers[(teachers.Length + i) % teachers.Length];
            }
        }
    }
}
