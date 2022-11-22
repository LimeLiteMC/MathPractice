using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Maths
{
    public class Addition
    {
        public static void AddPractice()
        {
            try
            {
                bool continU = true;
                while (continU)
                {
                    Random randInt = new Random();
                    int number1 = randInt.Next(0, 100);
                    int number2 = randInt.Next(0, 100);
                    Console.WriteLine($"What is {number1} + {number2}?");
                    int sum = number1 + number2;
                    int response = int.Parse(Console.ReadLine());
                    if (response == sum)
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
                    else if (response != sum)
                    {
                        Console.WriteLine($"Sorry that was incorrect! The correct answer was {sum}. Would you like to try another? (Y/N)");
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
            }
            catch (FormatException wrongnumber)
            {
                Console.WriteLine(wrongnumber.Message);
            }
        }
    }
}
