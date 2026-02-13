public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "Relax by breathing slowly and focusing on your breath.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);

            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}
