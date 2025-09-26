using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num = 1;
        int numcopy = num;
        int count = 0;

        while (numcopy > 0)
        {
            if (num % numcopy == 0)
                count++;
            numcopy -= 1;
        }

        if (count > 2)
        {
            Console.WriteLine("eded murekkebdir");
        }
        else if (count == 2)
        {
            Console.WriteLine("eded sadedir");
        }
        else
        {
            Console.WriteLine("ne sade ne de murekkebdir");
        }
    }
}
