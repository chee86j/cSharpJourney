// =====CONDITIONAL OPERATOR=====
/*  Instead of using the if...else statement, you can use the conditional operator (?:) 
    to evaluate a boolean expression and return one of two values based on the result. 
    The conditional operator has the following syntax:

    <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

    If the condition is true, the operator returns value1; otherwise, it returns value2. 
    The conditional operator is a concise way to write simple conditional statements. 
    Here's an example that demonstrates the use of the conditional operator:
*/

        // int saleAmount = 1001;
        // int discount = saleAmount > 1000 ? 100 : 50;
        // Console.WriteLine($"Discount: {discount}");

//  Output:
//     Discount: 100
//   In this example, the conditional operator checks if the saleAmount is greater than 1000.
//   If the condition is true, the operator assigns a discount of 100; otherwise, it assigns a discount of 50.
//   In this case, the saleAmount is 1001, so the discount is set to 100.

// =====RECAP=====
// You should remember the following facts about the conditional operator:

// You can use the conditional operator to reduce the size of your code, but you should ensure that the resulting 
// code is easily readable.
// You can use the conditional operator when you need to return a value that's based on a binary condition. 
// Your code will return the first option when the condition evaluates to true, and it will return the second option 
// when the condition evaluates to false.

// -----------------------------------------------------------------------------------------------------------------------

/*
    CODE CHALLENGE: Write code to display the result of a coin flip
    Here are your challenge requirements:

1.  Ensure that you have an empty Program.cs file open in Visual Studio Code.
    -If necessary, open Visual Studio Code, and then complete the following steps to 
    -prepare a Program.cs file in the Editor:
    -On the File menu, select Open Folder.
    -Use the Open Folder dialog to navigate to, and then open, the CsharpProjects folder.
    -In the Visual Studio Code EXPLORER panel, select Program.cs.
    -On the Visual Studio Code Selection menu, select Select All, and then press the Delete key.

2.  Use the Random class to generate a value.
    -Consider the range of numbers that is required.

3.  Based on the value generated, use the conditional operator to display either heads or tails.
    -There should be a 50% chance that the result is either heads or tails.

4.  Your code should be easy to read, but with as few lines as possible.
    -You should be able to accomplish the desired result in three lines of code.

Whether you get stuck and need to peek at the solution or you finish successfully, 
continue on to view a solution to this challenge.
*/

// Solution 1:
Random coin = new Random();
int coinFlip = coin.Next(0, 2);
string result = coinFlip == 0 ? "Heads" : "Tails";
Console.WriteLine(result);

// Solution 2:
Random twoHeadedCoin = new Random();
int flip = twoHeadedCoin.Next(0, 2);
Console.WriteLine(flip == 0 ? "Heads" : "Tails");

// Solution 3:
Random singleCoin = new Random();
Console.WriteLine((singleCoin.Next(0, 2) == 0) ? "Heads" : "Tails");

/*

As we progress from Solution 1 all the way to Solution 3, we can see that the code becomes more concise.
Solution 1 is the most verbose, with the Random object, the coinFlip variable, and the result variable.
Solution 2 removes the result variable, and Solution 3 removes the coinFlip variable.

The final solution is the most concise, with only the Random object and the Console.WriteLine() statement.
In all 3 Solutions Random.Next() is used to generate a random number between 0 and 1, which is then used 
to determine the result of the coin flip. A value of 0 represents "Heads", and a value of 1 represents "Tails".
*/