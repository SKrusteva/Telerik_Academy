using System;
using System.Collections.Generic;

namespace _08.Events
{
    public class Student // Subscriber
    {
        private string name;
        private int facultyNumber;
        public List<Student> examList = new List<Student>(50);

        public Student(string name, int facultyNumber, Department properDepartment)
        {
            this.Name = name;
            this.FacultyNumber = facultyNumber;
            properDepartment.CustomExam += Going;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }

        private void Going(object sender, ExamEventArgs e)
        {
            try
            {
                Inscribe(this);
            }
            catch (Exception ex)
            {
                throw new Exception("I really would take the examination, but unfortunately I will not be able.", ex.InnerException);
            }
        }

        private List<Student> Inscribe(Student customStudent)
        {
            examList.Add(customStudent);
            return examList;
        }
    }
}
