using System;
using AscendTest.Library;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = ValidationService.Validate("Abcd123_");
            var result = ValidationService.Validate("_Abcd123_");

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
