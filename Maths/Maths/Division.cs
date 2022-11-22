using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class Division
    {
        public static void DivisionPractice()
        {
            bool continU = true;
            while (continU)
            {
                try
                {
                    Random randInt = new Random();
                    int number2 = randInt.Next(0, 13);
                    int number1 = randInt.Next(0, 100) * number2;
                    Console.WriteLine($"What is {number1} / {number2}?");
                    int quotient = number1 / number2;
                    int response = int.Parse(Console.ReadLine());
                    if (response == quotient)
                    {
                        Console.WriteLine("Great job! You are correct! :) Would you like to continue?(Y/N)");
                        string morePractice = Console.ReadLine().ToUpper();
                        if (morePractice == "Y")
                        {
                            continU = true;
                        }
                        else if (morePractice == "N")
                        {
                            continU = false;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    else if (response != quotient)
                    {
                        Console.WriteLine($"Sorry that was incorrect! The correct answer was {quotient}. Would you like to try another? (Y/N)");
                        string morePractice = Console.ReadLine().ToUpper();
                        if (morePractice == "Y")
                        {
                            continU = true;
                        }
                        else if (morePractice == "N")
                        {
                            continU = false;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                catch (FormatException wrongnumber)
                {
                    Console.WriteLine(wrongnumber.Message);
                }
            }
        }
    }
}
