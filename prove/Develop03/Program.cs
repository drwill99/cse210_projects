using System;

class Program
{


    static void Main(string[] args)

    
    {
        Scripture original = new Scripture();
        string userInput = "";

        Welcome();

        string referance = original.getReference();
        string originalScripture = original.getScripture();
        
        Console.WriteLine($"{referance}: {originalScripture}");

        while(userInput != "quit")
        {
        userInput = Console.ReadLine();
        Console.Clear();
        DisplayScripture scripture = new DisplayScripture(originalScripture);
        scripture.Display();
        }

        static void Welcome()
        {
        Console.WriteLine("\nTest your memory! Press Enter to blank out some words. \nType 'quit' when done.");
        }


    }

    
}