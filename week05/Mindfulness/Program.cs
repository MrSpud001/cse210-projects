using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        // init classes
        BreathingActivity breathingActivity = new BreathingActivity("Breathing activity", "Breathing activity Description", 30);
        ListingActivity listingActivity = new ListingActivity("Listing activity", "Listing activity Description", 30, 0, ["prompt 1", "prompt 2", "prompt 3"]);
        ReflectActivity reflectActivity = new ReflectActivity("Reflect activity", "Reflect activity Description", 30, ["question 1","question 2", "question 3"], ["prompt 1", "prompt 2", "prompt 3"]);



        while (true)
        {
            // display menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Choose one: ");

     


            // accept user input
            string res = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("get ready");

         

            switch (res)
            {
                case "1":
                    breathingActivity.Run();
                    break;

                case "2":
                    reflectActivity.Run();
                    break;
                case "3":
                    listingActivity.Run();
                    break;
                case "4":
                    return;
                
                default:
                     Console.WriteLine("Invalid input ");
                     break;
                    
            }

        }




    }
}