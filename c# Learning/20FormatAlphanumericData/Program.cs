/*
    What is Composite Formatting?
    It uses numbered placeholders within a string. At run time, everything inside the 
    braces is resolved to a value that is also passed in based on their position.
*/

//  Example 1
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result); // Hello World!
Console.WriteLine("{0} {0} {0}!", first, second); // Hello Hello Hello!

/*
1.  Built-in "helper methods" are available for data types & variables of different 
    types. i.e. ToString() method.
2.  The literal string "{0} {1}!" forms a template, parts of which are replaced at 
    run time.
3.  The token {0} is replaced by the first argument after the string template, in 
    other words, the value of the variable first.
4.  The token {1} is replaced by the second argument after the string template, in
    other words, the value of the variable second.
5.  For the second Console.WriteLine() statement, observe that the tokens can be 
    reused with three instances of {0}. Also, the second variable argument, second, 
    isn't used. Yet, the code still runs without error.
*/

// --------------------------------------------------------------------------------

/*
    What is String Interpolation?
    It simplifies composite formatting. It allows you to embed expressions within
    string literals, using curly braces {}. The expressions are evaluated at run time.

    The same concept is used in JavaScript, Python, and other languages.
    i.e. ${expression}, f-string in Python.
*/

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!"); // Hello World!
Console.WriteLine($"{second} {first}!"); // World Hello!
Console.WriteLine($"{first} {first} {first}!"); // Hello Hello Hello!

// --------------------------------------------------------------------------------

/*
    ===Formatting Currency===
    In the following example we will be using the ":C" format specifier to format
    a number as a currency. It is used to present the price and discount variables
    as currency values.
*/

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Price: $123.45 (Save $50.00)

// --------------------------------------------------------------------------------

/*
    ===Country/region and language settings affect string formatting?===

    "Price: 123,45 € (Save 50,00 €)" could be from a German user's computer.
    "Price: $123.45 (Save $50.00)" could be from an American user's computer.
    "Price: £123.45 (Save £50.00)" could be from a British user's computer.

    The reason for the previous "€" output is that the string currency formatting 
    feature is dependent on the local computer setting for culture. In this context, 
    the term "culture" refers to the country/region and language of the end user. 
    The culture code is a five character string that computers use to identify the 
    location and language of the end user. The culture code ensures certain information 
    like dates and currency can be presented properly.

    For example:
    -the culture code of an English speaker in the USA is en-US.
    -the culture code of a French speaker in France is fr-FR.
    -the culture code of a French speaker in Canada is fr-CA.
*/

// --------------------------------------------------------------------------------

/*
    ===Formatting Numbers===
    
    When working with numeric data, you might want to format the number for readibility
    by including commas to delineate thousands, millions, billions, etc. 
*/

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// Measurement: 123,456.79 units

/*
    By default, the ":N" format specifier adds commas to the number and rounds it to
    two decimal places. The number of decimal places can be adjusted by adding a number
    after the colon. For example, ":N3" would round the number to three decimal places.
*/

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
// Measurement: 123,456.7891 units

// --------------------------------------------------------------------------------
/*
    ===Formatting Percentages===
    
    We use the P format specifier to format a number as a percentage. The number is
    multiplied by 100 and displayed with a percent sign.
*/

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
// Tax rate: 36.79%

// --------------------------------------------------------------------------------

/*
    ===Combining Formatting Approaches===
    
    String variables can store strings created using formatting techniques. In the 
    following example, decimals and decimal math results are formatted and stored 
    in the yourDiscount string using composite formatting.
*/

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
// You saved $7.56 off the regular $67.55 price.

// Note: You don't need to use the String.Format() with this string interpolation approach.

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
// You saved $7.56 off the regular $67.55 price. A discount of 11.19%!

// --------------------------------------------------------------------------------

/*
=====RECAP=====
Here are most important takeaways from this unit about string formatting:

-You can use composite formatting or string interpolation to format strings.

-With composite formatting, you use a string template containing one or more replacement 
tokens in the form {0}. You also supply a list of arguments that are matched with the 
replacement tokens based on their order. Composite formatting works when using string.
Format() or Console.WriteLine().

-With string interpolation, you use a string template containing the variable names you 
want replaced surrounded by curly braces. Use the $ directive before the string 
template to indicate you want the string to be interpolated.

-Format currency using a :C specifier.

-Format numbers using a :N specifier. Control the precision (number of values after the 
decimal point) using a number after the :N like {myNumber:N3}.

-Format percentages using the :P format specifier.

-Formatting currency and numbers depend on the end user's culture, a five character 
code that includes the user's country/region and language (per the settings on their 
computer).

*/