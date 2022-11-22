using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class Subtraction
    {
        public static void SubtractionPractice()
        {
            bool continU = true;
            while (continU) 
            { 
                try
                {    
                    Random randInt = new Random();
                    int number1 = randInt.Next(0, 100);
                    int number2 = randInt.Next(0, 100);
                    Console.WriteLine($"What is {number1} + {number2}?");
                    int difference = number1 + number2;
                    int response = int.Parse(Console.ReadLine());
                    if (response == difference)
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
                    else if (response != difference)
                    {
                        Console.WriteLine($"Sorry that was incorrect! The correct answer was {difference}. Would you like to try another? (Y/N)");
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
