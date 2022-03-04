using System;

namespace Numbers
{
    internal class Program
    {
        static int age = 15;
        static void Main(string[] args)
        {
            int num1=13;
            int num2 = 23;
            int sum;
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            decimal dpi = 3;
            sbyte x = 120;
            short y = 30000;
            int z = 2000000000;
            long myLong = 3285745603946790860;
            double dIDiv = d1 / num1;

            num1 = 13;
            num2 = 100;
            sum = num1 + num2;

            Console.WriteLine("num 1 is: " + num1);
            Console.WriteLine("num1:" + num1 + " + num2: " + num2 + " is " + sum);
            Console.WriteLine("d1/d2 is " + dDiv); 
            Console.WriteLine("f1/f2 is " + fDiv);
            Console.WriteLine("d1/num1 is " + dIDiv);

            Console.Read();
        }
    }
}
