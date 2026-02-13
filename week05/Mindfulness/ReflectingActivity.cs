public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you overcame something difficult."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?"
    };

    private Random _rand = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "Reflect on meaningful experiences.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(_prompts[_rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[_rand.Next(_questions.Count)]);
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}
