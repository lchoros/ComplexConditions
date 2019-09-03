using System;

namespace ExamTime
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamTimeCalculator.Calculate(9,30,9,50);
            ExamTimeCalculator.Calculate(16,0,15,0);
            ExamTimeCalculator.Calculate(9,0,8,30);
            ExamTimeCalculator.Calculate(9,0,10,30);
            ExamTimeCalculator.Calculate(14,0,13,55);
            ExamTimeCalculator.Calculate(11,30,8,12);
            ExamTimeCalculator.Calculate(10, 0, 10, 0);
            ExamTimeCalculator.Calculate(11, 30, 10, 55);
            ExamTimeCalculator.Calculate(11, 30, 12, 29);

            //int startHours = int.Parse(Console.ReadLine());
            //int startMinutes = int.Parse(Console.ReadLine());
            //int arrivalHours = int.Parse(Console.ReadLine());
            //int arrivalMinutes = int.Parse(Console.ReadLine());

            //string late = "Late";
            //string onTime = "On time";
            //string early = "Early";

            //int startTime = startHours * 60 + startMinutes;
            //int arrivalTime = arrivalHours * 60 + arrivalMinutes;

            //int arrivalTimeDifference = Math.Abs(startTime - arrivalTime);
            //int hours = arrivalTimeDifference / 60;
            //int minutes = arrivalTimeDifference % 60;
            //if (startTime < arrivalTime)
            //{
            //    Console.WriteLine(late);
            //    if (startTime - arrivalTime > 59)
            //    {
            //        Console.WriteLine("{0}:{1:D2} hours before the start", hours, minutes);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} before the start", minutes);
            //    }
            //}
            //else if(startTime >= arrivalTime && startTime - arrivalTime <= 30)
            //{
            //    Console.WriteLine(onTime);
            //    if(startTime - arrivalTime > 0)
            //    {
            //        Console.WriteLine("{0} minutes before the start", minutes);
            //    }
            //}
            //else if (startTime > arrivalTime && startTime - arrivalTime > 30)
            //{
            //    Console.WriteLine(early);
            //    if(startTime - arrivalTime > 59)
            //    {
            //        Console.WriteLine("{0}:{1:D2} hours before the start", hours, minutes);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} before the start", minutes);
            //    }
            //}
        }
    }
}
