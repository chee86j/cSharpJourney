/*  =====What is a BOOLEAN EXPRESSION?=====
    A Boolean expression is a logical statement that evaluates to either true or false. 
    It is commonly used in programming to make decisions based on conditions. 
    For example, in an if statement, the condition inside the parentheses is a Boolean 
    expression that determines whether the code block inside the if statement should
*/

// -------------------------------------------------------------------------------------

// =====EVALUATING EQUALITY and INEQUALITY=====
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//  Output:
//     True

/* This code snippet compares two strings, value1 and value2, after trimming and 
converting them to lowercase. The Trim() method removes any leading or trailing 
whitespace characters from the strings, and the ToLower() method converts the 
strings to lowercase. The comparison is done using the == operator, which checks 
if the two strings are equal.
*/

// -------------------------------------------------------------------------------------

// =====Use the INEQUALITY OPERATOR (!=)=====
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

//  Output:
//     False
//     True
//     True
//     False

// =====EVALUATING COMPARISONS=====
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

//  Output:
//     False
//     True
//     True
//     True

// -------------------------------------------------------------------------------------

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

//  Output:
//     True
//     False

/*  This code snippet demonstrates the use of the Contains() method to check if a
    string contains a specific substring. The first Console.WriteLine() statement 
    checks if the pangram string contains the substring "fox" and prints true 
    because the pangram contains the word "fox". The second Console.WriteLine() 
    statement checks if the pangram string contains the substring "cow" and prints 
    false because the pangram does not contain the word "cow".
*/

// -------------------------------------------------------------------------------------

// =====LOGICAL NEGATION=====
/*  Logical negation is the process of reversing the truth value of a Boolean expression. 
    The logical negation operator in C# is the exclamation mark (!). When applied to a 
    Boolean expression, it negates the value, turning true into false and false into true.

    DO NOT CONFUSE THE LOGICAL NEGATION OPERATOR (!) WITH THE INEQUALITY OPERATOR (!=).
*/

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

//  Output:
//     False
//     True

/*
=====RECAP=====
Here's the main takeaways you learned about evaluating Boolean expressions so far:

-There are many different kinds of expressions that evaluate to either true or false.
-Evaluate equality using the == operator.
-Evaluating equality of strings requires you to consider the possibility that the strings 
 have different case and leading or trailing spaces. Depending on your situation, use the 
 ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the 
 likelihood that two strings are equal.
-Evaluate inequality using the != operator.
-Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
-If a method returns a bool, it can be used as a Boolean expression.
-Use the logical negation operator ! to evaluate the opposite of a given expression.

*/