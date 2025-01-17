﻿// Code challenge - write code to implement the game rules

/*
1.  You must use either the do-while statement or the while statement as an outer 
    game loop.
2.  The hero and the monster start with 10 health points.
3.  All attacks are a value between 1 and 10.
4.  The hero attacks first.
5.  Print the amount of health the monster lost and their remaining health.
6.  If the monster's health is greater than 0, it can attack the hero.
7.  Print the amount of health the hero lost and their remaining health.
8.  Continue this sequence of attacking until either the monster's health or hero's 
    health is zero or less.
9.  Print the winner.
*/

/*
===EXAMPLE OUTPUT===
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int heroAttk = dice.Next(1, 11);
    monster -= heroAttk;
    Console.WriteLine($"Monster was damaged and lost {heroAttk} health and now has {monster} health.");

    if (monster <= 0) continue;

    int monsterAttk = dice.Next(1, 11);
    hero -= monsterAttk;
    Console.WriteLine($"Hero was damaged and lost {monsterAttk} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


/*
As you have seen, C# supports four types of iteration statements: for, foreach, 
do-while, and while. Microsoft's language reference documentation describes these 
statements as follows:

1.  The for statement: executes its body while a specified Boolean expression 
    (the 'condition') evaluates to true.
2.  The foreach statement: enumerates the elements of a collection and executes its 
    body for each element of the collection.
3.  The do-while statement: conditionally executes its body one or more times.
4.  The while statement: conditionally executes its body zero or more times.
*/


/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/

/*
The int.TryParse() method can be used to convert a string value to an integer. 
The method uses two parameters, a string that will be evaluated and the name of 
an integer variable that will be assigned a value. The method returns a Boolean 
value. The following code sample demonstrates using the int.TryParse() method:

// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
*/