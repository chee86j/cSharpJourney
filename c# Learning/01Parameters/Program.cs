// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Simiar to JavaScript, C# uses the Console.WriteLine() method to output text to the console.

'Console.WriteLine()' is a similar method to 'console.log()' in JavaScript.
---it will output the text to the console on a new line.

'Console.Write()' 
---is a similar method to 'process.stdout.write()' in JavaScript.
---it will output the text to the console on the same line.

i.e.
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is on a new line.");
        Console.Write("Hello, World!");
        Console.Write("This is on the same line.");

        output:
        Hello, World!
        This is on a new line.
        Hello, World!This is on the same line.

'Console.ReadLine()' 
---is a similar method to 'process.stdin()' in JavaScript.
---it will read the input from the console.
---this prompt will wait for the user to enter a value and press the 'Enter' key.

'Console.Read()' is a similar method to 'process.stdin()' in JavaScript.
---it will read the input from the console, but it will only read the first character of the input.

Data Types:
C# is a statically-typed language, meaning the type of a variable must be declared.

1. Value types:
   - int, float, double, bool, char
   Example:
        int number = 123;
        bool isActive = true;

2. Reference types:
   - string (commonly used)
   Example:
        string greeting = "Hello, World!";

Variables:
Variables in C# are declared by specifying the type followed by the variable name:
Example:
        int age = 25;

Constants:
Constants are variables whose value cannot be changed once initialized. Declared using the 'const' keyword.
Example:
        const double PI = 3.14159;

// Example of using variables and constants
        int age = 30;
        const string BIRTHDAY = "January 1st";
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Birthday: " + BIRTHDAY);


Overall, C# is a statically-typed language, meaning the type of a variable must be declared. It has similarities to
JavaScript in terms of syntax and structure, but there are differences in the way variables are declared and used.
The 'Console.WriteLine()' method is used to output text to the console, and variables can be declared and used to store
data in a program. Constants are variables whose value cannot be changed once initialized, and they are declared using
the 'const' keyword.
*/


/*
    Pre-requisites:
        Install the .NET SDK from https://dotnet.microsoft.com/download
        Install Visual Studio Code from https://code.visualstudio.com/
        Install the C# extension for Visual Studio Code 'C# Dev Kit' by Microsoft

    To create a new c# project:
        1. Open the terminal
        2. Navigate to the directory where you want to create the project
        3. Run the following command:
            'dotnet new console -n ProjectName'
        4. This will create a new folder with the project name specified
        5. Navigate to the project folder:
            'cd ProjectName'
        6. Open the project in Visual Studio Code:
            'code .'

    To run the program:
        1. Open the terminal
        2. Navigate to the directory where the file is located
        3. Run the following command:
            'dotnet run'
*/