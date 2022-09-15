using System;

namespace Intro_Program
{
    class Programme
    {
        static string OP()
        {
            return "namespace Intro_Program\r\n{\r\n    class Program\r\n    {\r\n        static double Vol(double length, double height, double width)\r\n        {\r\n            return length * height * width;\r\n        }\r\n\r\n        \r\n    \r\n        static void Main(string[] args)\r\n        {\r\n            Console.WriteLine(Vol(10, 20, 10));\r\n    \r\n        }\r\n    }\r\n}\r\n";
        }



        static void Main(string[] args)
        {
            Console.WriteLine(OP());

        }
    }
}
