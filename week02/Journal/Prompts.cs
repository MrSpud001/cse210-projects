public class Prompts
{
    public List<string> _prompts = ["Prompt 1","Prompt 2","Prompt 3","Prompt 4","Prompt 5"];

    Random random = new Random();

    public string GetPrompt()
    {
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }


}