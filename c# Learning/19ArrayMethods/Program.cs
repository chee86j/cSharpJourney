/* ----------Array.SORT()----------

The Array class contains methods that you can use to manipulate the content, 
arrangement, and size of an array. In this exercise, you code that performs 
various operations on an array of pallet identifiers. Your code could be the 
start of an application to track and optimize the usage of pallets for the company.
*/
// string[] pallets = ["B14", "A11", "B12", "A13"];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*
Expected Output:
    Sorted...
    -- A11
    -- A13
    -- B12
    -- B14

Note that the Sort() of the Array class sorts the items in the array Alphanumerically.
*/

/* ----------Array.REVERSE()----------

The Array.Reverse() method reverses the order of the items in an array. 
*/
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*
Expected Output:
    Reversed...
    -- B14
    -- B12
    -- A13
    -- A11
*/


/* ------------Array.Clear()------------

The Array.Clear() method enables you to eliminate the contents of specific elements 
in your array, replacing them with the array's default value. For instance, if you 
clear an element in a string array, the cleared value is replaced with null. Similarly,
when you clear an element in an int array, the replacement is 0 (zero).
*/

// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*
Expected Output:
    Clearing 2 ... count: 4
    -- 
    -- 
    -- B12
    -- A13
*/

/* ------------Empty String vs Null------------
When you use Array.Clear(), the elements that were cleared no longer reference a string 
in memory. In fact, the element points to nothing at all. Pointing to nothing is an 
important concept that can be difficult to grasp at first.

What if you attempt to retrieve the value of an element affected by the Array.Clear() 
method, could you do it?
*/

// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*
If you focus on the line of output After: , you might think that the value stored in 
pallets[0] is an empty string. However, the C# Compiler implicitly converts the null 
value to an empty string for presentation.
*/

/* ------------Call a String Helper Method on a Cleared Element------------
To prove that the value stored in pallets[0] after being cleared is null, you'll modify 
the code example to call the ToLower() method on pallets[0]. If it's a string, it 
should work fine. But if it's null, it should cause the code to throw an exception.
*/
// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/*
Expected Output:
"System.NullReferenceException: Object reference not set to an instance of an object."

This exception is thrown because the attempt to call the method on the contents of the 
pallets[0] element happens before the C# Compiler has a chance to implicitly convert 
null to an empty string.

The moral of the story is that Array.Clear() removes an array element's reference to 
a value if one exists. To fix this, you might check for null before attempt to print 
the value.

To avoid the error, add an if statement before accessing an array element that is 
potentially null. 
"if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");"
*/

/* ------------Resize an Array------------
The Array.Resize() method enables you to change the size of an array. 
Here, you're calling the Resize() method passing in the pallets array by reference, 
using the ref keyword. In some cases, methods require you pass arguments by value 
(the default) or by reference (using the ref keyword).

This is equivalent to using slice() in JS to resize an array, but note that JS
will require a manual fill for the new elements, while C# will automatically fill
the new elements with the default value for the type of the array. push() in JS
will then be used to add new elements to the array.
*/

//-----Resize an Array to Add New Elements-----
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

/*
Expected Output:
    Clearing 2 ... count: 4
    -- 
    -- 
    -- B12
    -- A13

    Resizing 6 ... count: 6
    -- 
    -- 
    -- B12
    -- A13
    -- C01
    -- C02
*/

//-----Resize an Array to remove Elements-----
/*
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
Expected Output:
    Clearing 2 ... count: 4
    -- 
    -- 
    -- B12
    -- A13

    Resizing 6 ... count: 6
    -- 
    -- 
    -- B12
    -- A13
    -- C01
    -- C02

    Resizing 3 ... count: 3
    -- 
    -- 
    -- B12


-----Can you Remove null Elements from an Array?-----
If the Array.Resize() method doesn't remove empty elements from an array, is there 
another helper method that does the job automatically? No. The best way to empty 
elements from an array would be to count the number of non-null elements by iterating 
through each item and increment a variable (a counter). Next, you would create a 
second array that is the size of the counter variable. Finally, you would loop 
through each element in the original array and copy non-null values into the new array.
*/

/* ------------Final Takeaway------------
----Clear() method to empty the values out of elements in the array.
----Resize() method to change the number of elements in the array, removing or adding 
    elements from the end of the array.
----New array elements and cleared elements are null, meaning they don't point to a 
    value in memory.
----C# Array.Resize() creates a new array and modifies the reference.
----JavaScript arrays are dynamic, so resizing is done via modifying length, slice(), 
    or push().
----New elements in C# default to 0 or null, while JavaScript defaults to undefined.