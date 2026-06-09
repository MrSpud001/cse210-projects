class ReflectActivity : Activity
{
    private List<String> _prompts = [];
    private List<String> _questions = [];
      public ReflectActivity(string name, string desc, int duration, List<String> questions, List<String> prompts) : base(name,desc,duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        ShowSpinner(5);

        DisplayStartingMessage();
        Console.WriteLine($"how many seconds: ");


        string res = Console.ReadLine();

        int resNum = Int32.Parse(res);

     

        Console.WriteLine($"{GetRandomPrompt()}");


        Console.WriteLine($"press enter when ready: ");

        string res2 = Console.ReadLine();





        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(resNum);

        while (true)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime > futureTime)
            {
                DisplayEndingMessage();
                return;
            }
            Console.WriteLine($"{GetRandomQuestion()}");
            ShowCountdown(5);



        }

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randPrompt = random.Next(0, _prompts.Count);
        return _prompts[randPrompt];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randQuestion = random.Next(0, _questions.Count);
        return _questions[randQuestion];
    }

}