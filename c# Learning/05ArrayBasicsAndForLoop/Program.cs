/*  Declare a new array of strings that can hold 3 elements.
    Assign values to each element in the array.
    Attempt to assign a value to an index that is out of range.
    Run the program and observe the error message.
    Fix the error by removing the out of range assignment.
    Run the program again and observe the output.
    
*/

/*  'string[]' is a data type that represents an array of strings.
    'new string[3]' creates a new array of strings with a length of 3 w/ 'new' operator
    creating a new instance of the array.
    '[]' the square brackets are used to access elements in the array w/ the number inside
    representing the index of the element.
    
    KEY POINTS:
    Zero-based Indexing: The first element in an array is at index 0.
    Data Type Consistency: All elements in an array must have the same data type.
*/

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000"; // Error: Index was outside the bounds of the array.
// this will throw an error because the array has a length of 3, so the last index is 2

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// You can ReAssign the value of an element in an array by using the index and the assignment operator '='.
// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");




/*
You can initialize an Array During Declaration:
    string[] fraudulentOrderIDs = new string[] { "A123", "B456", "C789" };
    string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
*/
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
/* string[] fraudulentOrderIDs = { "A123", "B456", "C789" };  is also valid
   and be aware that you may see both older syntax and newer syntax in use.
*/

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
// the 'Length' property returns the number of elements in the array.

/*
Output:
    First: A123
    Second: B456
    Third: C789
    Reassign First: F000
    There are 3 fraudulent orders to process.
*/

=====Recap=====
Here's the most important things to remember when working with arrays:

-An array is a special variable that holds a collection of related data elements.
-You should memorize the basic format of an array variable declaration.
-Access each element of an array to set or get its values using a zero-based index inside of square brackets.
-If you attempt to access an index outside of the boundary of the array, you get a run time exception.
-The Length property gives you a programmatic way to determine the number of elements in an array.
*/

// -------------------------------------------------------------------------------------------------------

// FOR LOOPS
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

/*
Output:
    Bin 1 = 200 items (Running total: 200)
    Bin 2 = 450 items (Running total: 650)
    Bin 3 = 700 items (Running total: 1350)
    Bin 4 = 175 items (Running total: 1525)
    Bin 5 = 250 items (Running total: 1775)
    We have 1775 items in inventory.


Recap
Here's a few things to remember about foreach statements and incrementing values that you learned in this unit:

Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
Use the ++ increment operator to add 1 to the current value of a variable.
*/