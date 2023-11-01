using System;

class Program
{
    static void Main(string[] args)
    {
        int userDecision = -1;
        DisplayWelcomeMessage();
        //string prompt = GeneratePrompt();
        List<string> userJournal = new List<string>();
        JournalPrompts userPrompt = new JournalPrompts();
        Journal journal = new Journal();


        while(userDecision != 5)
        {
            userDecision = UserChoice();
            

            if (userDecision == 1)
            {

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();  

                string prompt = userPrompt.getPrompt();
                Console.WriteLine(prompt);

                string userInput = Console.ReadLine(); 
               
                Entry entry = new Entry(dateText, prompt, userInput);
                             
                journal._entry.Add(entry);

                userJournal.Add($"{entry.formatEntry()}");

            }

            else if (userDecision == 2)
            {

                foreach (Entry line in journal._entry)
                
                {
                    line.Display();
                }

            }

            else if (userDecision == 3)
            {

                Console.WriteLine("What would you like to name your file? ");
                string fileName = Console.ReadLine();
                string completeFileName = ($"{fileName}.txt");

                
                using (StreamWriter outputFile = new StreamWriter(completeFileName))
                {
                    foreach (string line in userJournal){
                        
                        outputFile.WriteLine($"{line} ~~");

                    }
                    
                }

            }

            else if (userDecision == 4)
            {

                Console.WriteLine("What File would you like to read?: ");
                string pullJournal = Console.ReadLine();
                string completePullJournal = ($"{pullJournal}.txt");
                string[] lines = System.IO.File.ReadAllLines(completePullJournal);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~~");
                    
                    journal._entry.Add(new Entry(parts[0], parts[1], parts[2]));
                    

                }
            }

            else if (userDecision == 5)
            {

                Environment.Exit(0);
            }

            else
            {

                Console.WriteLine("That isn't an option, please try again.");
            }
        
        }
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("\n Welcome to your Journal.\n (Please enter the number of your selection): ");
           
        }   

        static int UserChoice()
        {
            Console.WriteLine(" 1. Write\n 2. Display\n 3. Save\n 4. Load\n 5. Quit");
            int userSelection = int.Parse(Console.ReadLine());
            
            return userSelection;
        }

    }     

}