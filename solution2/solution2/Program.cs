using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 234;
        int count = 0;
        do
        {
            num /= 10;
            count++;
        } while (num != 0);
        Console.WriteLine(count);
    }
}

