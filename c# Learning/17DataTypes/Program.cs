/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
*/

/*
=====Expected Output=====
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615
*/

/*
===============Recap===============

----Values are stored as bits, which are simple on / off switches. Combining enough of 
    these switches allows you to store just about any possible value.
----There are two basic categories of data types: value and reference types. The difference
    is in how and where the values are stored by the computer as your program executes.
----Simple value types use a keyword alias to represent formal names of types in the .NET 
    Library.

----An integral type is a simple value data type that can hold whole numbers.
----There are signed and unsigned numeric data types. Signed integral types use 1 bit 
    to store whether the value is positive or negative.
----You can use the MaxValue and MinValue properties of numeric data types to evaluate 
    whether a number can fit in a given data type.
*/

// ------------------------------------------------------------------------------------------------------

/*
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

/*
=====Expected Output=====
Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

===============Recap===============
----A floating-point type is a simple value data type that can hold fractional numbers.
----Choosing the right floating-point type for your application requires you to 
    consider more than just the maximum and minimum values that it can hold. You must 
    also consider how many values can be preserved after the decimal, how the numbers 
    are stored, and how their internal storage affects the outcome of math operations.
----Floating-point values can sometimes be represented using "E notation" when the 
    numbers grow especially large.
----There's a fundamental difference in how the compiler and runtime handle decimal as 
    opposed to float or double, especially when determining how much accuracy is 
    necessary from math operations.

*/

// ------------------------------------------------------------------------------------------------------

/*
int[] data;
data = new int[3];

The above code is equivalent to the following code:
int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

*/

/*
=====Expected Output=====
Hello World!

--Value Types--
val_A: 2
val_B: 5

--Reference Types--
ref_A[0]: 5
ref_B[0]: 5

===============Recap===============
----Value types can hold smaller values and are stored in the stack. 
    Reference types can hold large values, and a new instance of a reference 
    type is created using the new operator. Reference type variables hold a 
    reference (the memory address) to the actual value stored in the heap.
----Reference types include arrays, strings, and classes.

*


/*
Choose the data type that meets the boundary value range requirements of your application
Your choice of a data type can help to set the boundaries for the size of the data you
might store in that particular variable. For example, if you know a particular 
variable should only store a number between 1 and 10,000 otherwise it's outside 
of the boundaries of what would be expected, you would likely avoid byte and sbyte 
since their ranges are too low.

Furthermore, you would likely not need int, long, uint, and ulong because they can 
store more data than is necessary. Likewise, you would probably skip float, double, 
and decimal if you didn't need fractional values. You might narrow it down to short 
and ushort, of which both may be viable. If you're confident that a negative value 
would have no meaning in your application, you might choose ushort (positive unsigned 
integer, 0 to 65,535). Now, any value assigned to a variable of type ushort outside 
of the boundary of 0 to 65535 would throw an exception, thereby subtly helping you 
enforce a degree of sanity checking in your application.

Start with choosing the data type to fit the data (not to optimize performance)
You may be tempted to choose the data type that uses the fewest bits to store data 
thinking it improves your application's performance. However, some of the best advice 
related to application performance (that is, how fast your application runs) is to 
not "prematurely optimize". You should resist the temptation to guess at the parts 
of your code, including the selection of data types that may impact your application's 
performance.

Many assume that because a given data type stores less information it must use less 
of the computer's processor and memory than a data type that stores more information. 
Instead, you should choose the right fit for your data, then later you can empirically 
measure the performance of your application using special software that provides 
factual insights to the parts of your application that negatively impact performance.
*/

/*
When in doubt, stick with the basics
While you've looked at several considerations, as you're getting started, for 
simplicity's sake you should prefer a subset of basic data types, including:
    int - for whole numbers
    decimal - for fractional numbers and currency
    bool - for true / false values
    string - for alphanumeric value

Choose specialty complex types for special situations
Don't reinvent data types if one or more data type already exists for a given purpose. 
The following examples identify where a specific .NET data types can be useful:
    byte - for storing binary data and other character sets
    double - for storing fractional values with a high degree of accuracy
    System.DateTime - for storing dates and times
    System.TimeSpan - for storing time intervals
*/