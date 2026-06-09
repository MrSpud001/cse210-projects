class Activity
{
    private string _name;
    private string _desc;
    private int _duration;

    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _desc = desc;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} start message");
        Console.WriteLine(" ");
        
        Console.WriteLine($"{_desc}");
        Console.WriteLine(" ");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"{_name} has ended");
        
    }

    public void ShowSpinner(int seconds)
    {
        int num = seconds;
        while (num > 0)
        {
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(500);

            Console.Write("\b \b\b \b\b \b"); 
            num -= 1;
        }
    }

    public void ShowCountdown(int seconds)
    {
        int num = seconds;
        while (num > 0)
        {
            
            Console.Write($"{num}");
            Thread.Sleep(1000);
            num -= 1;
            Console.Write("\b \b\b \b"); 

        }

    }
}