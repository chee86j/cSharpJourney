/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

Expected Output:
This will throw an error because you cannot add an integer and a string together.
"Cannot implicitly convert type 'string' to 'int'"
*/

// -----Compilers make safe conversions-----

/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Expected Output:
This will output "24" because the integer is converted to a string and 
concatenated with the other string.
*/


//  -----Question: Is it possible that attempting to change the value's data type would 
//  result in a loss of information?'-----

/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

Expected Output:
int: 3
decimal: 3

Since any int value can easily fit inside of a decimal, the compiler performs the 
conversion.
The term widening conversion means that you're attempting to convert a value from a 
data type that could hold less information to a data type that can hold more 
information. In this case, a value stored in a variable of type int converted to a 
variable of type decimal, doesn't lose information.

When you know you're performing a widening conversion, you can rely on implicit 
conversion. The compiler handles implicit conversions.

*/

// -----PERFORM A CAST-----

/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

Expected Output:
decimal: 3.14
int: 3

The variable myDecimal holds a value that has precision after the decimal point. 
By adding the casting instruction (int), you're telling the C# compiler that you 
understand it's possible you'll lose that precision, and in this situation, it's fine. 
You're telling the compiler that you're performing an intentional conversion, an 
explicit conversion.
*/

// -----Determine if your conversion is a "widening conversion" or a "narrowing conversion"-----

/*
The term narrowing conversion means that you're attempting to convert a value from a 
data type that can hold more information to a data type that can hold less information. 
In this case, you may lose information such as precision (that is, the number of values
after the decimal point). An example is converting value stored in a variable of type 
decimal into a variable of type int. If you print the two values, you would possibly
notice the loss of information.

When you know you're performing a narrowing conversion, you need to perform a cast. 
Casting is an instruction to the C# compiler that you know precision may be lost, 
but you're willing to accept it.

If you're unsure whether you lose data in the conversion, write code to perform a 
conversion in two different ways and observe the changes. Developers frequently 
write small tests to better understand the behaviors, as illustrated with the next 
sample.

Example:
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

Expected Output:
Decimal: 1.23456789
Float  : 1.2345679ss
*/

/*
-----CONVERT CLASS METHODS-----
-ToString() : this method is used to convert a  Number Value --> String.
    i.e.
        int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();
        Console.WriteLine(message);

        Output: 57

-Parse() : this method is used to convert a     String --> Number value.
    i.e.
        string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);

        Output: 12

-Convert() : this method is used to convert a   Number Value --> Another Number Value.
    i.e.
        string value1 = "5";
        string value2 = "7";
        int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(result);

        Output: 35
        
        The ToInt32() method has 19 overloaded versions allowing it to accept virtually
        every data type. You used the Convert.ToInt32() method with a string here, but 
        you should probably use TryParse() when possible. So, when should you use the 
        Convert class? The Convert class is best for converting fractional numbers into 
        whole numbers (int) because it rounds up the way you would expect.

-The following example demonstrates what happens when you attempt to cast a decimal 
 into an int (a narrowing conversion) versus using the Convert.ToInt32() method to 
 convert the same decimal into an int.

    i.e.
        int value = (int)1.5m; // casting truncates
        Console.WriteLine(value);

        int value2 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value2);

        Output: 1
                2
*/

/*
-----RECAP-----
You covered several important concepts of data conversion and casting:

----Prevent a runtime error while performing a data conversion
----Perform an explicit cast to tell the compiler you understand the risk of losing data
----Rely on the compiler to perform an implicit cast when performing an expanding 
    conversion
----Use the () cast operator and the data type to perform a cast (for example, 
    (int)myDecimal)
----Use the Convert class when you want to perform a narrowing conversion, but want to 
    perform rounding, not a truncation of information
*/

/*
1.  TryParse() : this method is used to convert a String --> Number Value.
    i.e.
        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
        Console.WriteLine($"Measurement: {result}");
        }
        else
        {
        Console.WriteLine("Unable to report the measurement.");
        }

    Output: Measurement: 102

    The TryParse() method is a safer way to convert a string to a number. It returns a 
    boolean value indicating whether the conversion was successful. If the conversion 
    was successful, the out parameter contains the converted value. If the conversion 
    was unsuccessful, the out parameter contains the default value for the data type
    (in this case, 0).
    
2.  Use the parsed int later in your code:
    i.e.
        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");
    
    Output: Measurement: 102
            Measurement (w/ offset): 152

3.  Modifything the string variable to a value that can't be parsed
    i.e.
        string value = "bad";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        if (result > 0)
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");

    Output: Unable to report the measurement.

    Since result is defined outside of the if statement, result can be accessed later 
    in your code outside of the code blocks. So then result can be checked for a value 
    greater than zero before allowing result + offset to be written as output. 
    Checking for a result value greater than zero avoids printing an offset value 
    after the Unable to report the measurement. message.
*/

/*
-----RECAP-----
The TryParse() method is a valuable tool. Here are few quick ideas to remember.

----Use TryParse() when converting a string into a numeric data type.
----TryParse() returns true if the conversion is successful, false if it's 
    unsuccessful.
----Out parameters provide a secondary means of a method returning a value. In this 
    case, the out parameter returns the converted value.
----Use the keyword out when passing in an argument to a method that has defined an 
    out parameter.