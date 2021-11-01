using System;

namespace ProblemSolvingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string ReverseString(string input)
        {
            //convert input to array
            char[] inputArray = input.ToCharArray();
            //reverse array
            Array.Reverse(inputArray);
            //return array converted to string 
            return new string(inputArray);
        }

        public string CapitalizeLetter(string input)
        {

        }
    }
}
