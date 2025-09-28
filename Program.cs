using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copy = 0;
            while (num != 0)
            {
                copy = num % 10;
                Console.WriteLine(copy);
                num /= 10;
                
            }

        }

    }
}