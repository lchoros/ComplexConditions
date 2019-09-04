using System;

namespace ExamTime
{
    class TestExamTimeCalculator
    {
        static void Main(string[] args)
        {
                int examHour = int.Parse(Console.ReadLine());
                int examMinutes = int.Parse(Console.ReadLine());
                int arrivalHours = int.Parse(Console.ReadLine());
                int arrivalMinutes = int.Parse(Console.ReadLine());
                ExamTimeCalculator.Calculate(examHour, examMinutes, arrivalHours, arrivalMinutes);
                ExamTimeCalculator.Calculate(9, 30, 9, 50);
                ExamTimeCalculator.Calculate(16, 0, 15, 0);
                ExamTimeCalculator.Calculate(10, 0, 10, 0);
                ExamTimeCalculator.Calculate(11, 30, 10, 55);
        }
    }
}
