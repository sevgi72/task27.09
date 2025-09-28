
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        while (count < 100)
        {
            sum = sum + count;
            count = count + 2;
        }

        Console.WriteLine(sum);