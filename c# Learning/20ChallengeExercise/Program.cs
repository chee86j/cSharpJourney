// Explore String Interpolation

/*
You need to create the code to print a receipt for the customer purchasing shares of an investment 
product. The shares are purchased automatically at the end of the year based on a series of payroll 
deductions, so the number of shares purchased usually contains a decimal amount. To print the receipt, 
you would likely need to combine data of different types, including fractional values, currency, 
and percentages in precise ways.
*/

/* ----Solution----
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Subtotal: {subtotal:C}");
Console.WriteLine($"       Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
*/

/*
Output:
Invoice Number: 1201
   Shares: 25.457 Product
     Subtotal: $2,750.00
       Tax: 15.83%
     Total Billed: $3,185.19
*/

/* ----Solution----
Discover Padding and Alignment
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
*/

/*
Output:
Hello World!
*/

/*
It may have seemed a bit strange that a keyword that represents a data type has methods you can call 
in the same way that you call methods on the Console class. The fact is that there are many similar 
methods on the string data type and any literal string or variable of type string.

Here's a brief list of categories of these built-in methods so you can get an idea of what's possible.

-Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
-Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), 
GetHashcode(), the Length property)
-Methods that help you determine what's inside of a string, or even retrieve just a part of the string 
(Contains(), StartsWith(), EndsWith(), Substring())
-Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), 
Insert(), Remove())
-Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
*/

// Formating Strings by adding whitespace before or after

/* The PadLeft() method adds blank spaces to the left-hand side of the string so that the total number 
of characters equals the argument you send it. In this case, you want the total length of the string 
to be 12 characters.
*/

/* ----Solution----
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
*/

/*
Output:
----Pad this
Pad this----
*/

/* ----Solution----
string paymentId = "769C";

var formattedLine = paymentId.PadRight(6);

Console.WriteLine(formattedLine);
*/

/*
Output:
769C
*/

/* ----Solution----
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/

/*
Output:
1234567890123456789012345678901234567890
769C    Mr. Stephen Ortega       $5,000.00
*/


// RECAP

/*
There's a few important takeaways from this unit.

- The string data type, literal strings, and variables of type string each implement many helper methods
  to format, modify, and perform other operations on strings.
- The PadLeft() and PadRight() methods add white space (or optionally, another character) to the total 
  length of a string.
- Use PadLeft() to right-align a string.
- Some methods are overloaded, meaning they have multiple versions of the method with different 
  arguments that affect their functionality.
- The += operator concatenates a new string on the right to the existing string on the left.
*/

// -----------------------------------------------------------------------------------------------------

// Challenge to apply string interpolation to form a letter

/*
For the sales and marketing company's newest investment products, you send thousands of personalized 
letters to the company's existing clients. Your job is to write C# code to merge personalized 
information about the customer. The letter contains information like their existing portfolio and 
compares their current returns to projected returns if they were to invest in using the new products.

The writers have decided on the following example marketing message. Here's the desired output 
(using fictitious customer account data).
*/

/*
Expected Output:

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/





/*
Expected Output:

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be $63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/

// Starting Data:

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic below

// ----Solution 1----
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N3} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.");
Console.WriteLine($"Given your current volume, your potential profit would be {newProfit:C}.");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = $"{currentProduct,-20} {currentReturn,10:P2} {currentProfit,20:C}";
comparisonMessage += $"\n{newProduct,-20} {newReturn,10:P2} {newProfit,20:C}";

Console.WriteLine(comparisonMessage);


/* ----Solution 2----
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
*/



