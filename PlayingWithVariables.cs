using System;

namespace PlayingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Kari";
            int age = 29;
            char firstLetter = 'k';
            bool isHappy; 
            double temperature = 92.5;
            decimal money = 150582.7m;

            Console.WriteLine($"My name is { firstName }, I am {age} years old.");
            Console.WriteLine($"My name starts with {firstLetter} and it is {temperature} outside today.");
            Console.WriteLine($"I wish I had {money} in my bank account.");


        }
    }
}
