using System.Collections.Generic;

namespace OOP.View
{
    static class Printer
    {
        public static void Print(string message)
        {
            System.Console.Write(message);
        }

        public static void PrintLine(string message)
        {
            System.Console.WriteLine(message);
        }       
    }
}
