using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int numtest = num;
        while (numtest % 2 == 0 && numtest > 1)
        {
            numtest /= 2;
        }
        if (numtest == 1)
        {
            Console.WriteLine("ikinin quvvetidir");
        }
        else
            Console.WriteLine("ikinin quvveti deyil");

    }
}