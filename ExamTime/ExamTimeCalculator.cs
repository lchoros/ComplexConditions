using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTime
{
    public class ExamTimeCalculator
    {
        public static void Calculate(int examHour, int examMinutes, int arrivalHours, int arrivalMinutes)
        {
            string late = "Late";
            string onTime = "On time";
            string early = "Early";

            int examTime = (examHour * 60) + examMinutes;
            int arrivalTime = (arrivalHours) * 60 + arrivalMinutes;
            int timeDifference = arrivalTime - examTime;

            string studentArival = late;
            if (timeDifference < -30)
            {
                studentArival = early;
            }
            else if (timeDifference <= 0 && timeDifference <= 30)
            {
                studentArival = onTime;
            }

            string result = string.Empty;
            if (timeDifference != 0)
            {
                int hours = Math.Abs(timeDifference / 60);
                int minutes = Math.Abs(timeDifference % 60);
                if (hours > 0)
                {
                    result = $"{hours}:{minutes:00} hours ";
                }
                else
                {
                    result = $"{minutes} minutes ";
                }
                if (timeDifference < 0)
                {
                    result += "before the start";
                }
                else
                {
                    result += "after the start";
                }
            }
            Console.WriteLine(studentArival);
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
