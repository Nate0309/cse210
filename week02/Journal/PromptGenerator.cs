using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompt;

    public PromptGenerator()
    {
        prompt = new List<string>
        {
            "What challenges did you come across today?",
            "What was the strongest emotion you felt today?",
            "Who did you make smile today?",
            "Did anything stand out to you from your scripture study today?",
            "Where did you go today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random promptGenerator = new Random();
        int promptnum = promptGenerator.Next(prompt.Count);
        return prompt[promptnum];
    }
}