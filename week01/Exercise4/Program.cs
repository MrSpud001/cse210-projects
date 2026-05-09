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

        int sum = 0;
        int max_num = 0;

        foreach(int num in numbers)
        {
            if (num > max_num)
            {
                max_num = num;
            }

            sum += num;
            
        }
        Console.WriteLine($"sum is: {sum}");

        Console.WriteLine($"average is: {sum / numbers.Count}");

        Console.WriteLine($"maximum is: {max_num}");



    }
}