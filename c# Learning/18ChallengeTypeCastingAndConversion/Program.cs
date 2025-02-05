string[] values = { "12.3", "45", "ABC", "11", "DEF" };

/* C
Create a looping structure that can be used to iterate through each string 
value in the array values.

Complete the required code, placing it within the array looping structure 
code block. It's necessary to implement the following business rules in your code logic:

----Rule 1: If the value is alphabetical, concatenate it to form a message.

----Rule 2: If the value is numeric, add it to the total.

----Rule 3: The result should match the following output:

            Message: ABCDEF
            Total: 68.3
*/

decimal total = 0;
string message = string.Empty; // Alternative: string message = "";

foreach (var value in values)
{
    decimal number = 0; // Alternative: decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

/*  Explanation
    1.  We start by declaring empty variables for the total and message.
    2.  Then we use a foreach loop to iterate through each value in the values array.
        a.  We declare a decimal variable named number and set it to 0 so that we can 
            store the converted value of the string later.
        b.  We use the decimal.TryParse() method to convert the string value to a decimal 
            number. If the conversion is successful, we add the number to the total.
        c.  If the conversion is unsuccessful, we concatenate the value to the message.
    3.  Finally, we print out the message and total values.
*/

/*
    Keep in mind that C# is a strongly typed language, and it's important to handle
    type conversions carefully to avoid runtime errors. 

    1. The decimal.TryParse() method:   i.e.    decimal myDecimal = 1.23456789m;
    2. The int.TryParse() method:       i.e.    int myInt = 123456789;
    
*/