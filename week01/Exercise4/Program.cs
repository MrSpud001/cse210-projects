using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");


        Console.WriteLine("enter list of numbers, 0 to exit");

        List<int> numbers = new List<int>();


        while (true)
        {
            Console.WriteLine("enter number: ");
            int res = int.Parse(Console.ReadLine());

            if (res == 0)
            {
                break;
            }

            numbers.Add(res);

        };

        foreach(int num in numbers)
        {
        Console.WriteLine(num);
            
        };

    }
}