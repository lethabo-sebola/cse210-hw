using System;
using System.Formats.Asn1;

Journal journal = new Journal();
// Creativity: I added a mood field to each journal entry, allowing users to record their emotional state alongside their written responses. This addition provides a more holistic view of the user's experiences and can help identify patterns in mood over time.

List<string> prompts = new List<string>
     {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today?",
        "What is something I am grateful for today?",
     };
string choice = "";

while (choice != "5")
{
    Console.WriteLine("Please select one of the following options:");
    Console.WriteLine("1. Write a new entry");
    Console.WriteLine("2. Display the journal");
    Console.WriteLine("3. Save journal to a file");
    Console.WriteLine("4. Load journal from a file");
    Console.WriteLine("5. Quit");
    Console.Write("Enter your choice (1-5): ");

    choice = Console.ReadLine();

    if (choice == "1")
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Console.Write("How are you feeling today? ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry();
        entry.Date = date;
        entry.Prompt = prompt;
        entry.Response = response;
        entry.Mood = mood;

        journal.Entries.Add(entry);
    }

        else if (choice == "2")
        {
            journal.DisplayEntries();
        }
        else if (choice == "3")
        {
            Console.Write("Enter the filename to save the journal: ");
            string filename = Console.ReadLine();

            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved successfully.");
        }
        else if (choice == "4")
        {
            Console.Write("Enter the filename to load the journal: ");
            string filename = Console.ReadLine();

            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded successfully.");
        }
    
}
