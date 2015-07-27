using System;
using System.Collections.Generic;

namespace _08.Events
{
    public class ExamEventArgs : EventArgs
    {
        private string subject;
        private DateTime date;
        private string place;

        public ExamEventArgs(string subject)
        {
            this.Subject = subject;
        }

        public ExamEventArgs(string subject, DateTime date)
            : this(subject)
        {
            this.Date = date;
        }

        public ExamEventArgs(string subject, string place)
            : this(subject)
        {
            this.Place = place;
        }

        public ExamEventArgs(string subject, DateTime date, string place) //Exam announcement
            : this(subject)
        {
            this.Date = date;
            this.Place = place;
        }

        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Place
        {
            get { return this.place; }
            set { this.place = value; }
        }
    }
}