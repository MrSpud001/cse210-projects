using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.WriteLine("what is the number");
        // string number = Console.ReadLine();
        // int number_as_int = int.Parse(number);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        while (true)
        {
            Console.WriteLine("what is your guess");
            string res = Console.ReadLine();
            int res_as_int = int.Parse(res);


            if (res_as_int == number)
            {
                Console.WriteLine("guess correct");
                break;
            }
            else if (res_as_int > number) {
                Console.WriteLine("lower");
                
            }
            else
            {
                Console.WriteLine("higher");
            }

        }





        // do
        // {
        //     Console.WriteLine("what is your guess");
        //     res = Console.ReadLine();
        //     int res_as_int = int.Parse(res);


        //     if (res_as_int == number_as_int)
        //     {
                
        //     }
        //     else if (res_as_int > number_as_int) {
                
        //     }

        // } while (res != number_as_int);


    //    while (guess != magicNumber)
    //     {
    //         Console.Write("What is your guess? ");
    //         guess = int.Parse(Console.ReadLine());

    //         if (magicNumber > guess)
    //         {
    //             Console.WriteLine("Higher");
    //         }
    //         else if (magicNumber < guess)
    //         {
    //             Console.WriteLine("Lower");
    //         }
    //         else
    //         {
    //             Console.WriteLine("You guessed it!");
    //         }

    //     }  



    }
}