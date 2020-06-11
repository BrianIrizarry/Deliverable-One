using System;
using System.Text.RegularExpressions;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {


            //VACATION TYPE CODE

            Console.WriteLine("Select your vacation type from the following list: ");

            string[] vacationTypeList = { "Musical", "Tropical", "Adventurous" };

            foreach (string i in vacationTypeList)
            {
                Console.WriteLine(i);
            }

            string vacationTypeUserInput = Console.ReadLine();

            string vacationType1 = "New Orleans!";
            string vacationType2 = "Beach Vacation in Mexico!";
            string vacationType3 = "Whitewater Rafting the Grand Canyon!";



            //GROUP SIZE CODE

            Console.WriteLine("Use an integer to state your group size.");

            int groupSize = int.Parse(Console.ReadLine());


            //RESULT: USING NESTED IF STATEMENTS AND CONCATENATION

            if (vacationTypeUserInput == "Musical")
                if ((groupSize >= 0) && (groupSize < 3))
                {
                    Console.WriteLine("Fly first class to " + vacationType1);
                }

                else if ((groupSize > 2) && (groupSize < 6))
                {
                    Console.WriteLine("Take a helicopter to " + vacationType1);
                }

                else if (groupSize > 5)
                {
                    Console.WriteLine("Charter a flight to " + vacationType1);
                }

            
            
            if (vacationTypeUserInput == "Tropical")
                if ((groupSize >= 0) && (groupSize < 3))
                {
                    Console.WriteLine("Fly first class to " + vacationType2);
                }

                else if ((groupSize > 2) && (groupSize < 6))
                {
                    Console.WriteLine("Take a helicopter to " + vacationType2);
                }

                else if (groupSize > 5)
                {
                    Console.WriteLine("Charter a flight to " + vacationType2);
                }


            
            if (vacationTypeUserInput == "Adventurous")
                if ((groupSize >= 0) && (groupSize < 3))
                {
                    Console.WriteLine("Fly first class to " + vacationType3);
                }

                else if ((groupSize > 2) && (groupSize < 6))
                {
                    Console.WriteLine("Take a helicopter to " + vacationType3);
                }

                else if (groupSize > 5)
                {
                    Console.WriteLine("Charter a flight to " + vacationType3);
                }
           



            




        }
    }
}
