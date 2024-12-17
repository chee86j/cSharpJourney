/*
C# just like JavaScript has if else statements. In this example, we are going to create a simple dice game. 
The game will roll three dice and add the total. If the total is greater than 14, the player wins. 
If the total is less than 15, the player loses. 

IF / ELSE STATEMENTS 
If the condition is true, the code inside the if statement will run.
If the condition is false, the code inside the else statement will run.
i.e. 
        if (condition)
        {
            // code to run if condition is true
        }
        else
        {
            // code to run if condition is false
        }

MATHEMATICAL OPERATORS - C# supports the following mathematical operators:
        '+' is the addition operator
        '-' is the subtraction operator
        '*' is the multiplication operator
        '/' is the division operator
        '%' is the modulus operator
        '++' is the increment operator
        '--' is the decrement operator
        '+=', '-=', '*=', '/=' are compound assignment operators

BOOLEAN EXPRESSIONS - A boolean expression is a statement that can be either true or false.
i.e. 
        bool isTrue = true;
        bool isFalse = false;                                            *Note: there is no '===' in C#
        '=' is an assignment operator    '==' is a comparison operator    Use Equals() method to compare strings
        '!=' is a not equal operator
        '>' is greater than              '<' is less than
        '>=' is greater than or equal to '<=' is less than or equal to

LOGICAL OPERATORS - Logical operators are used to combine multiple boolean expressions.
i.e. 
        '&&' is the AND operator
        '||' is the OR operator
        '!' is the NOT operator

A Code Block is a group of statements that are enclosed in curly braces '{}'.
Note: A Boolean expression is made up of 3 parts: 
        1. The 'if' keyword
        2. A boolean expression inside parentheses '()'
        3. A code block inside curly braces '{}'
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}



/*
Nesting has now been included in the code. Nesting is when you place an if statement inside another if statement.
*/