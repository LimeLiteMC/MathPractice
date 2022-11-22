using Maths;
using System.Runtime.InteropServices;

class MathHub {
    static void Main()
    {
        Console.WriteLine("Welcome to Math Practice!");
        bool continU = true;
        while (continU)
        {
            Console.WriteLine("What would you like to practice?(Type: 'A' for Addition, 'D' for Division, 'M' for Multiplication, and 'S' for Subtraction)");
            string practiceChoice = Console.ReadLine().ToUpper();

            if (practiceChoice == "M")
            {
                Console.WriteLine("Multiplication");
                Multiplication.MultiplicationPractice();
            }
            else if (practiceChoice == "D")
            {
                Console.WriteLine("Division");
                Division.DivisionPractice();
            }
            else if (practiceChoice == "A")
            {
                Console.WriteLine("Addition");
                Addition.AddPractice();
            }
            else if (practiceChoice == "S")
            {
                Console.WriteLine("Subtraction");
                Subtraction.SubtractionPractice();
            }
            else
            {
                Console.WriteLine("Invalid input, please retry.");
            }
            Console.WriteLine("Would you like to practice something else?(Y/N)");
            string yesONo = Console.ReadLine().ToUpper();
            if (yesONo == "Y")
            {
                continue;
            }
            else if (yesONo == "N")
            {
                continU = false;
            }
        }
    }
}