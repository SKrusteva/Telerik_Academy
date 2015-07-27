using System;
using System.Text;

namespace _07.Timer
{
    class TimerTest
    {
        static void PrintStars()
        {
            StringBuilder star = new StringBuilder();
            Console.WriteLine(star.Append('*', 6));
        }

        static void PrintPlus()
        {
            StringBuilder plus = new StringBuilder();
            Console.WriteLine(plus.Append('+', 10));
        }

        static void Main()
        {
            try
            {
                Timer timer = new Timer(3);
                timer.execute += PrintStars;
                timer.execute += PrintPlus;
                timer.Run();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
