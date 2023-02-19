using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("hihihi");


            var result = Calcuator(10, 2);
            Console.WriteLine(result);

        }


        static void Feature1()
        {
            Console.WriteLine("Feature1");
        }


        static int Calcuator(int a , int b)
        {
            return a + b;
        }
    }
}
