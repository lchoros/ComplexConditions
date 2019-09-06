 using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            decimal studioPrice = 76.00M;
            decimal apartmentPrice = 77.00M;
            decimal studioRent = studioPrice * nights;
            decimal apartmentRent = apartmentPrice * nights;

            if(month.Equals("may") || month.Equals("october"))
            {
                studioPrice = 50.00M;
                apartmentPrice = 65.00M;
                studioRent = studioPrice * nights;
                apartmentRent = apartmentPrice * nights;

                if (nights > 7 && nights <= 14)
                {
                    studioRent -= studioRent * 0.05M;
                }
                else if(nights > 14)
                {
                    studioRent -= studioRent * 0.30M;
                }
            }
            if(month.Equals("june") || month.Equals("september"))
            {
                studioPrice = 75.20M;
                apartmentPrice = 68.70M;
                studioRent = studioPrice * nights;
                apartmentRent = apartmentPrice * nights;
                if (nights > 14)
                {
                    studioRent -= studioRent * 0.20M;
                }
            }

            if(nights > 14)
            {
                apartmentRent -= apartmentRent * 0.10M;
            }
            Console.WriteLine("Apartment: {0:F2} lv.", apartmentRent);
            Console.WriteLine("Studio: {0:F2} lv.", studioRent);
        }
    }
}
