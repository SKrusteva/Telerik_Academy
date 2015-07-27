using System;

namespace ExtDelegatesLambdaLinq
{ //[3],[4],[5]
    class Student
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        public Student(string first, string last, DateTime birth)
        {
            this.FirstName = first;
            this.LastName = last;
            this.DateOfBirth = birth;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public int Age()
        {
            int age = 0;
            if (DateTime.Now.Month - this.DateOfBirth.Month < 0)
            {
                age = DateTime.Now.Year - this.DateOfBirth.Year - 1;
            }
            else if (DateTime.Now.Month - this.DateOfBirth.Month == 0)
            {
                if (DateTime.Now.Day - this.DateOfBirth.Day < 0)
                {
                    age = DateTime.Now.Year - this.DateOfBirth.Year - 1;
                }
                else
                {
                    age = DateTime.Now.Year - this.DateOfBirth.Year;
                }
            }
            else if (DateTime.Now.Month - this.DateOfBirth.Month > 0)
            {
                age = DateTime.Now.Year - this.DateOfBirth.Year;
            }

            return age;
        }

        public override string ToString()
        {
            int years = this.Age();
            
            return this.FirstName + " " + this.LastName + ", " + years;
        }
    }
}