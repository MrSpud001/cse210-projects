class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts = [];



    public ListingActivity(string name, string desc, int duration, int count, List<String> prompts) : base(name,desc,duration)
    {
        _prompts = prompts;
        
    }


    public void Run()
    {
        ShowSpinner(5);

        DisplayStartingMessage();
        Console.WriteLine($"how many seconds: ");


        string res = Console.ReadLine();

        int resNum = Int32.Parse(res);



        Console.WriteLine($"prompt: ");
        Console.WriteLine();
        GetRandomPrompt();

        Console.WriteLine($"start in: ");
        ShowCountdown(5);

    



        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(resNum);

        int listCount = 0;
        while (true)
        {    
            DateTime currentTime = DateTime.Now;
            if (currentTime > futureTime)
            {
                Console.WriteLine($"things listed: {listCount}");
                
                DisplayEndingMessage();
                return;
            }

            string res2 = Console.ReadLine();



            listCount += 1;
        }
           

        


    }


    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randPrompt = random.Next(0, _prompts.Count);

        Console.WriteLine($"{_prompts[randPrompt]}");
        
    }

    public List<String> GetListFromUser()
    {
        return [];
    }

}