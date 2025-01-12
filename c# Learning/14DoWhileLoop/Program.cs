/*
===DO-WHILE LOOP===
We can use the do-while loop to execute a block of code at least once, and then 
repeatedly execute it as long as a given condition is true. Below is an example
of a do-while loop that generates random numbers between 1 and 10 until the 
number 7 is generated.

===Code Snippet:===
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

===Example Output:===
9
4
6
4
8
7
*/

/*
===WHILE LOOP===
The while loop is used to execute a block of code as long as a given condition is true.
Below is an example of a while loop that generates random numbers between 1 and 10 
until the number 3 or less is generated.

Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

*/

// Using the continue statement to step directly to the Boolan expression of the loop
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*

Consider the difference between the continue and break statements.

As you saw in this last step, the continue statement transfers execution to the end of 
the current iteration. This behavior is different than the behavior we saw with the 
break statement. The break statement terminates the iteration (or switch) and 
transfers control to the statement that follows the terminated statement. If there is 
no statement after the terminated statement, then control transfers to the end of 
the file or method.

===Recap===
There's a few important ideas you should take away from this unit:

==The do-while statement iterates through a code block at least once, and might continue 
to iterate based on a Boolean expression. The evaluation of the Boolean expression 
usually depends on some value generated or retrieved inside of the code block.

==The while statement evaluates a Boolean expression first, and continues to iterate 
through the code block as long as the Boolean expression evaluates to true.

==The continue keyword to step immediately to the Boolean expression.
*/