// bool flag = true;
// int value = 0;

// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

/*
### Recap ###
Here are a few important things to remember about code blocks:

W-hen you declare a variable inside a code block, its visibility is local to that 
code block and that variable cannot be accessed outside of the code block.

-To ensure that a variable is visible both inside and outside of a code block, you 
must declare the variable prior to the code block (outside and above the code block).

-Ensure that variables are initialized before your code attempts to access them (for 
all potential code execution paths).
*/

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

/*
Recap
Here are a few important things to remember about if statement code blocks and readability:

-If you realize you have only one line of code listed within the code blocks of an 
if-elseif-else statement, you can remove the curly braces of the code block and white space.
Microsoft recommends that curly braces be used consistently for all of the code blocks of 
an if-elseif-else statement (either present or removed consistently).

-Only remove the curly braces of a code block when it makes the code more readable. It's always 
acceptable to include curly braces.

-Only remove the line feed if it makes the code more readable. Microsoft suggests that your 
code will be more readable when each statement is placed on its own code line.
*/

/*
Challenge:
1. Create a program that:
   - Declares an 'age' variable outside any code blocks
   - Uses if-elseif-else statements without curly braces
   - Prints different messages based on age ranges:
     * Under 13: "Child"
     * 13-19: "Teen"
     * 20+: "Adult"
   
2. Requirements:
   - Use single-line if statements without curly braces
   - Ensure proper indentation
   - Initialize the age variable before using it

Example solution will look similar to the name checking code above,
but with age comparisons instead.
*/

// Solution:
// int age = 15;

// if (age < 13)
//     Console.WriteLine("Child");
// else if (age <= 19)
//     Console.WriteLine("Teen");
// else
//     Console.WriteLine("Adult");

