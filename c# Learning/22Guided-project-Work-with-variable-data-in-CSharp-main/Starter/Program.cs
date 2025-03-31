// #1 the ourAnimals array will store the following: 
// Note explicit type declarations
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// #2 variables that support data entry
// '?' is used to declare nullable types
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];
// JS equivalent: let ourAnimals = Array(maxPets).fill().map(() => Array(7).fill(""));

// #4 create sample data ourAnimals array entries
// Switch Statement and data population
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

    }

    // String concatenation
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// #5 display the top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            // JS: readResult = prompt("Press the Enter key to continue");

            break;

        case "2":
            // Display all dogs with specified characteristics (multi-term support)
            string rawInput = "";

            while (string.IsNullOrWhiteSpace(rawInput))
            {
                Console.WriteLine("\nEnter dog characteristics to search for separated by commas");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    rawInput = readResult.Trim().ToLower();
                }
            }

            // Split and clean search terms
            string[] searchTerms = rawInput.Split(',');
            for (int i = 0; i < searchTerms.Length; i++)
            {
                searchTerms[i] = searchTerms[i].Trim();
            }

            Array.Sort(searchTerms); // sort alphabetically

            bool anyMatchesFound = false;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    string dogDesc = ourAnimals[i, 4].ToLower() + " " + ourAnimals[i, 5].ToLower();
                    string dogNickname = ourAnimals[i, 3];

                    List<string> matchedTerms = new();

                    foreach (string term in searchTerms)
                    {
                        Console.WriteLine($"searching...{term}");

                        if (!string.IsNullOrWhiteSpace(term) && dogDesc.Contains(term))
                        {
                            Console.WriteLine($"Our dog {dogNickname} matches your search for {term}!");
                            matchedTerms.Add(term);
                        }
                    }

                    if (matchedTerms.Count > 0)
                    {
                        // Display dog's info
                        Console.WriteLine($"{dogNickname} ({ourAnimals[i, 0]})");
                        Console.WriteLine(ourAnimals[i, 4]);
                        Console.WriteLine(ourAnimals[i, 5]);

                        anyMatchesFound = true;
                    }
                }
            }

            if (!anyMatchesFound)
            {
                Console.WriteLine($"\nNone of our dogs are a match for: {string.Join(", ", searchTerms)}");
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        default:
            break;
    }

} while (menuSelection != "exit");