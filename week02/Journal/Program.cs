using System;

class Program
{
    static void Main(string[] args)
    {
    
        Prompts _prompts = new Prompts();
        Journal _journal = new Journal();
    

        while (true)
        {
            Console.WriteLine("Select option: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            

            string res = Console.ReadLine();

            switch (res)
            {
               case "1":
                    string promptText = _prompts.GetPrompt();

                    Console.WriteLine($"Prompt: {promptText}");
                    Console.WriteLine("Input response: ");
                    Entry newEntry = new Entry();
                    string entryText = Console.ReadLine();
                     

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    newEntry._date = dateText;
                    newEntry._entryText = entryText;
                    newEntry._promptText = promptText;

                    _journal.AddEntry(newEntry);

                    break;


               case "2":
                    _journal.DisplayAll();
                    break;

               case "3":
                    Console.WriteLine("Input filename: ");
                    string fileToLoad = Console.ReadLine();
                    _journal.LoadFile(fileToLoad);
                    break;

               case "4":
                    Console.WriteLine("Input filename: ");
                    string filename = Console.ReadLine();
                    _journal.SaveToFile(filename);
                    break;

               case "5":
                    Console.WriteLine("Quitting program ");
                    return;

               default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            
        }


    }
}