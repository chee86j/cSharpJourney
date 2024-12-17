// Features in This Code
// Multiple Dice Rolls:

// User specifies how many dice to roll.
// Rolls are displayed one by one with slight delays for effect.
// Rolling Animation:

// Uses Thread.Sleep() to simulate a brief delay before showing results, making it more engaging.
// Roll Again Loop:

// User can roll dice as many times as they want.
// Program ends when the user types anything other than "yes".

using System;           // Import the System namespace for Console and Random classes
using System.Threading; // Similart to setTimeout() in JavaScript for adding delays to imitate delay effects

class Program // Define a class named Program
{
    static void Main(string[] args) // Similar to app.listen() in Express.js, the Main method is the entry point of the program
    {
        Random dice = new Random(); // New instance of Random class to generate random numbers
        string playAgain; // Declare a string variable to store user input for playing again like 'let playAgain' in JavaScript

        Console.WriteLine("\n🎲 Welcome to the Dice Roller!"); // Initial Greeting

        do
        {
            // Get number of dice from the user
            Console.WriteLine("How many dice would you like to roll?");
            int numOfDice;
            while (!int.TryParse(Console.ReadLine(), out numOfDice) || numOfDice <= 0)
            /* Input validation: Check if the input is a positive number. Readline() returns a string prompted by the used, 
             so we use int.TryParse() to validate & convert the input to an integer similar to parseInt() in JavaScript.
            */
            {
                Console.WriteLine("Please enter a valid positive number.");
            }

            Console.WriteLine($"🎲 Rolling {numOfDice} dice...");
            Thread.Sleep(1000); // Simulate rolling animation

            // Roll and display results for each dice
            for (int i = 0; i < numOfDice; i++) // Similar to JS for loop (let i = 0; i < numOfDice; i++)
            {
                int roll = dice.Next(1, 7); // Next method generates a random number between 1 and 7 (exclusive). This is a stateful method.
                Console.WriteLine($"Dice {i + 1}: {roll}");
                Thread.Sleep(1000); // Add a slight delay for each dice roll similar to setTimeout(() => console.log("Rolling dice..."), 1000);
            }

            // Ask if the user wants to roll again
            Console.WriteLine("\nWould you like to roll again? (yes/no)");
            playAgain = Console.ReadLine()?.Trim().ToLower(); // Do while loop like JavaScript. Trim() removes leading and trailing whitespaces just
            // like .trim() in JavaScript. ToLower() converts the input to lowercase to make it case-insensitive.
        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! 🎲");
    }
}

/* Recap
    - To call methods of a class in the .NET Class Library, use the format ClassName.MethodName().
    - Stateless methods like Math.Max() don’t depend on an object’s state and are called directly on the class.
    - Stateful methods like Random.Next() require an instance (object) of the class because they rely on the object’s state.
    - Use the new operator to create an object (instance) of a class, like Random.
    - Console.WriteLine() is similar to console.log() in JavaScript for output.
    - Console.ReadLine() captures user input as a string, and int.TryParse() safely converts it to an integer for validation.
*/

/*
RETURN VALUE
    Some methods are designed to complete their function and end "quietly". In other words, they don't return a value when they finish. 
    They are referred to as void methods.

OVERLOAD METHODS
    Methods with the same name but different parameters are called overloaded methods. 
    They allow you to use the same method name for different purposes. 
    i.e.
            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);
    The first WriteLine() method uses a method signature that defines an integer parameter.
    The second WriteLine() method uses a method signature that defines no parameters.
    The third WriteLine() method uses a method signature that defines a string parameter.

    To examine the overloaded versions of Random.Next(), enter the following code
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

    If you run this code, wou will see something like this:
            First roll: 342585470
            Second roll: 43
            Third roll: 89 

Visual Studio Code includes INTELLISENSE, which is a feature that provides code completion suggestions as you type.
*/

/*
The second way to learn about overloaded versions of the methods is to consult the documentation for the method.
For example, to learn about the Random.Next() method, you can visit the Microsoft documentation page for the Random class.
The documentation page lists all the overloaded versions of the Next() method, along with their descriptions and parameter requirements.

To navigate "on-page" to a description of the second overloaded version, select Next(Int32).

Documentation for each version of the method includes:

Brief description of the method's functionality
Method's definition
Parameters that the method accepts
Return values
Exceptions that can be raised
Examples of the method in use
Other remarks about the method


RECAP
    - Methods might accept no parameters or multiple parameters, depending on how they were designed and implemented. 
      When passing in multiple parameters, separate them with a , symbol.
    - Methods might return a value when they complete their task, or they might return nothing (void).
    - Overloaded methods support several implementations of the method, each with a unique method signature 
      (the number of parameters and the data type of each parameter).
    - IntelliSense can help write code more quickly. It provides a quick reference to methods, their return values, 
      their overloaded versions, and the types of their parameters.
    - learn.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work.
*/