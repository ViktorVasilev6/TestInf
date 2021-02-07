using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches: ");
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.56;
            Console.WriteLine("Centimeters: " + cm);
        }
    }
}
