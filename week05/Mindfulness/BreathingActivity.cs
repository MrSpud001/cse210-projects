class BreathingActivity : Activity
{
    public BreathingActivity(string name, string desc, int duration) : base(name,desc,duration)
    {
        
    }


    public void Run()
    {

        ShowSpinner(5);

        DisplayStartingMessage();
        Console.WriteLine($"how many seconds: ");


        string res = Console.ReadLine();

        int resNum = Int32.Parse(res);

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
            Console.WriteLine($"breathe in");

            ShowCountdown(5);

            Console.WriteLine($"breathe out");

            ShowCountdown(5);

        }

        
    }
}