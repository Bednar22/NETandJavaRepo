using System;
using System.Collections.Generic;
using System.Linq;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> numbers = new List<int>() { 7, 15 };
            List<string> results = FizzBuzzer.MillNumbers(numbers);
            foreach (var array in results)
                Console.WriteLine(string.Join(" ", array));
         
            
        }
    }
}
