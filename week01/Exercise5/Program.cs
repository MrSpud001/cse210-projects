using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string username = PromptUserName();

        int usernum = PromptUserNumber();

       int num_squared = SquareNumber(usernum);


        DisplayResult(username,num_squared);


        static void DisplayWelcome()
        {
            
        Console.WriteLine("program start");

        }

        static string PromptUserName()
        {
            Console.Write("input name: ");
            
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("input number: ");
            int res = int.Parse(Console.ReadLine());
            return res;
        }

        static int SquareNumber (int num)
        {

            return num * num;
        }
        

        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
            
        }


    }
}