using System;
using System.Runtime.CompilerServices;


// EXCEEDING REQUIREMENTS
// the HideRandomWords() function in Scripture.cs chooses only words that are not already hidden, ensuring that every loop hides 3 words unless there is less than 3 words left


class Program
{
    static void Main(string[] args)
    {
        string _scripture1 = "In the beginning God created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters. And God said, Let there be light: and there was light.";
        Reference _reference1 = new Reference("Genesis", 1, 1,3);

        Scripture newScripture = new Scripture(_reference1, _scripture1);





        while (true)
        {
            Console.WriteLine(newScripture.GetDisplayText());
            
            Console.WriteLine(" ");
            Console.WriteLine("enter to continue, or 'quit' to finish.");

            string res = Console.ReadLine();
            if (res == "quit")
            {
                return;
            }

            if (newScripture.IsCompletelyHidden())
            {
                return;
            }

            newScripture.HideRandomWords(3);
            Console.Clear();


        }



    }
}