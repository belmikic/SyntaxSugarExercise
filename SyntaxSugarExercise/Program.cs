using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"The number is less than nine" : "The number is greater than or equal to 9";

            Console.WriteLine(response);

        }
    }
}
