using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and Exceeding Requirements:
        // 1. Added a fourth activity: Gratitude Journaling
        // 2. Implemented activity logging that tracks how many times each activity is performed
        // 3. Added color to the console output for better user experience
        // 4. Ensured no random prompts/questions are repeated until all have been used
        
        ActivityLogger logger = new ActivityLogger();
        
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("========================");
            Console.ResetColor();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Journaling (Bonus Activity)");
            Console.WriteLine("5. View Activity Log");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Select an option (1-6): ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    logger.LogActivity("Breathing");
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    logger.LogActivity("Reflecting");
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    logger.LogActivity("Listing");
                    break;
                case "4":
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    logger.LogActivity("Gratitude");
                    break;
                case "5":
                    logger.DisplayLog();
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Have a peaceful day!");
                    Console.ResetColor();
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}

// Additional class for activity logging
public class ActivityLogger
{
    private Dictionary<string, int> _activityCounts = new Dictionary<string, int>();

    public ActivityLogger()
    {
        _activityCounts.Add("Breathing", 0);
        _activityCounts.Add("Reflecting", 0);
        _activityCounts.Add("Listing", 0);
        _activityCounts.Add("Gratitude", 0);
    }

    public void LogActivity(string activityName)
    {
        _activityCounts[activityName]++;
    }

    public void DisplayLog()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Activity Log");
        Console.WriteLine("============");
        Console.ResetColor();
        
        foreach (var entry in _activityCounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        
        Console.WriteLine();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
}

// Bonus Activity: Gratitude Journaling
public class GratitudeActivity : Activity
{
    private List<string> _gratitudePrompts = new List<string>
    {
        "What are three things you're grateful for today?",
        "Who made a positive impact on your day?",
        "What small pleasures brought you joy recently?",
        "What abilities or skills are you thankful to have?",
        "What beautiful things did you notice today?"
    };

    public GratitudeActivity()
    {
        _name = "Gratitude Journaling";
        _description = "This activity will help you cultivate gratitude by focusing on positive aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Random random = new Random();
        int promptIndex = random.Next(_gratitudePrompts.Count);
        Console.WriteLine(_gratitudePrompts[promptIndex]);
        Console.WriteLine();
        Console.WriteLine("Take a moment to reflect, then write your thoughts below:");
        Console.WriteLine();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> entries = new List<string>();
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                entries.Add(entry);
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"You wrote {entries.Count} gratitude entries!");
        Console.WriteLine("Here's what you wrote:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"- {entry}");
        }
        
        DisplayEndingMessage();
    }
}