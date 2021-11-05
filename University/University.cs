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
            Student[] newArray = new Student[students.Length + 1];
            for (int i = 0; i < students.Length; i++)
            {
                newArray[i] = students[i];
            }
            newArray[students.Length] = student;
            students = newArray;
        }

        /// <summary>
        /// Remove student from university
        /// </summary>
        /// <param name="student">Given student</param>
        public void Remove(Student student)
        {
            int removeIndex = 0;
            bool isContain = false;
            for (int i = 0; i < students.Length; i++)
            {

                if (student.Equals(students[i]))
                {
                    removeIndex = i;
                    isContain = true;
                    break;
                }
            }

            if (isContain)
            {
                Student[] newArray = new Student[students.Length - 1];
                int k = 0;
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i == removeIndex)
                    {
                        k++;
                    }
                    newArray[i] = students[k];
                    k++;
                }
                students = newArray;
            }
        }

        /// <summary>
        /// Add given teacher to teachers
        /// </summary>
        /// <param name="teacher"></param>
        public void Add(Teacher teacher)
        {
            Teacher[] newArray = new Teacher[teachers.Length + 1];
            for (int i = 0; i < students.Length; i++)
            {
                newArray[i] = teachers[i];
            }
            newArray[students.Length] = teacher;
            teachers = newArray;
        }

        /// <summary>
        /// Distrib students to teachers
        /// </summary>
        public void DistribStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].teacher = teachers[(i + i * teachers.Length) % teachers.Length];
            }
        }
        /// <summary>
        /// Get students list for given teacher
        /// </summary>
        /// <param name="teacher">Given teacher</param>
        /// <returns>Students list for given teacher</returns>
        public Student[] GetStudentsForTeacher(Teacher teacher)
        {
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (teacher.Equals(students[i].teacher))
                {
                    count++;
                }
            }

            Student[] result = new Student[count];
            int k = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].teacher == teacher)
                {
                    result[k] = students[i];
                    k++;
                }
            }

            return result;
        }
    }
}
