// See https://aka.ms/new-console-template for more information
// Characters Problem
using System;

namespace Intro_Program
{
    class Program
    {
        static double Vol(double length, double height, double width)
        {
            return length * height * width / 1000;
        }

        
    
        static void Main(string[] args)
        {
            Console.WriteLine(Vol(10, 20, 10));
    
        }
    }
}
