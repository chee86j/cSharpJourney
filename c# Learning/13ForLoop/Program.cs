// ### We use the 'BREAK' keyword to exit the loop when i is equal to 7 ###

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }


// ### Looping through each element of an array ###

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// Note you can't update the value of the array element in the foreach loop


// ### Overcoming the limitation of the foreach statement using the for statement ###
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

// RECAP
// Here are a few of the takeaways from this unit:

// --The for iteration statement allows you to iterate through a block of code a specific number of times.
// --The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parentheses: the initializer, condition, and iterator.
// --It's common to use the for statement when you need to control how you want to iterate through each item in an array.
// --If your code block has only one line of code, you can eliminate the curly braces and white space if you wish.