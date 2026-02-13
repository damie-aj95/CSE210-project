public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who do you appreciate?",
        "What are your strengths?"
    };

    private Random _rand = new Random();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "List positive things in your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(_prompts[_rand.Next(_prompts.Count)]);
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
}
