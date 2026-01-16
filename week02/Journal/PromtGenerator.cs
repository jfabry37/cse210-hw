public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What is something new you learned today?",
        "Describe a challenge you faced today and how you overcame it.",
        "who made you smile today?",
        "what do you regret from today?",
        "What are you grateful for today?",
        "Write about a memorable moment from today."
    };
     Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}