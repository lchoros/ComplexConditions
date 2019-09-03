using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTime
{
    public class ExamTimeCalculator
    {
        public static void Calculate(int startHours, int startMinutes, int arrivalHours, int arrivalMinutes)
        {
            string late = "Late";
            string onTime = "On time";
            string early = "Early";

            int startTime = startHours * 60 + startMinutes;
            int arrivalTime = arrivalHours * 60 + arrivalMinutes;

            int arrivalTimeDifference = Math.Abs(startTime - arrivalTime);
            int hours = arrivalTimeDifference / 60;
            int minutes = arrivalTimeDifference % 60;
            if (startTime < arrivalTime)
            {
                Console.WriteLine(late);
                if (startTime - arrivalTime > 59)
                {
                    Console.WriteLine("{0}:{1:D2} hours after the start", hours, minutes);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", minutes);
                }
            }
            else if (startTime >= arrivalTime && startTime - arrivalTime <= 30)
            {
                Console.WriteLine(onTime);
                if (startTime - arrivalTime > 0)
                {
                    Console.WriteLine("{0} minutes before the start", minutes);
                }
            }
            else if (startTime > arrivalTime && startTime - arrivalTime > 30)
            {
                Console.WriteLine(early);
                if (startTime - arrivalTime > 59)
                {
                    Console.WriteLine("{0}:{1:D2} hours before the start", hours, minutes);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", minutes);
                }
            }
        }
    }
}
