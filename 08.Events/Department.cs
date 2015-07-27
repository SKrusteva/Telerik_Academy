using System;

namespace _08.Events
{
    public class Department // Publisher
    {
        public event EventHandler<ExamEventArgs> CustomExam;

        public void Announce()
        {
            Console.WriteLine("There will be an exam. Check later for date and place.");
            OnAnnounce(new ExamEventArgs("Database", new DateTime(2015, 1, 12, 9, 0, 0), "2104"));
        }

        protected virtual void OnAnnounce(ExamEventArgs currentExam)
        {
            EventHandler<ExamEventArgs> handler = CustomExam;
            try
            {
                if (handler != null)
                {
                    handler(this, currentExam);
                }

                Console.WriteLine("The exam on {0} is going to be on {1:dd.MM.yyyy, HH:mm} in {2}.",
                    currentExam.Subject, currentExam.Date, currentExam.Place);
            }
            catch (Exception e)
            {
                throw new Exception("The examination will not take place due to unforeseen circumstances.", e.InnerException);
            }
        }
    }
}