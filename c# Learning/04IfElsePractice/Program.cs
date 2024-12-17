/*
    This code snippet is a practice of the if-else statements in C#.
    Requirements:
        1. A random number generator is used to generate a random number between 0 and 11.
        2. The random number generated is stored in the variable 'daysUntilExpiration'.
        3. The variable 'discountPercentage' is initialized to 0.
        4. The code block checks the value of 'daysUntilExpiration' using if-else statements.
        5. If 'daysUntilExpiration' is 0, the code block prints "Your subscription has expired."
        6. If 'daysUntilExpiration' is 1, the code block prints "Your subscription expires within a day!" and sets 'discountPercentage' to 20.
        7. If 'daysUntilExpiration' is less than or equal to 5, the code block prints "Your subscription expires in {daysUntilExpiration} days." and sets 'discountPercentage' to 10.
        8. If 'daysUntilExpiration' is less than or equal to 10, the code block prints "Your subscription will expire soon. Renew now!"
        9. Additionally if 'discountPercentage' is greater than 0, the code block prints "Renew now and save {discountPercentage}%."
        This appears as an additional message if the subscription is about to expire.
*/

using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        // Combine discount check and message into a single condition
        if (discountPercentage > 0)
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
    }
}

/*
    If / Else / Else If Statements in C#:
    - If statements are used to execute a block of code if a condition is true.
    - Else statements are used to execute a block of code if the same condition is false.
    - Else If statements are used to specify a new condition to test if the first condition is false.
    - We can also nest if-else statements to check multiple conditions.
*/


/*
This Solution can be further optimized by using Switch (Expressions) which we will learn later on:

using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);

        int discountPercentage = daysUntilExpiration switch
        {
            0 => PrintAndReturn("Your subscription has expired.", 0),
            1 => PrintAndReturn("Your subscription expires within a day!", 20),
            <= 5 => PrintAndReturn($"Your subscription expires in {daysUntilExpiration} days.", 10),
            <= 10 => PrintAndReturn("Your subscription will expire soon. Renew now!", 0),
            _ => 0
        };

        if (discountPercentage > 0)
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
    }

    // Helper method for printing and returning a value
    private static int PrintAndReturn(string message, int discount)
    {
        Console.WriteLine(message);
        return discount;
    }
}

*/

