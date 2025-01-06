/*
    A switch statement is a control statement that allows a value to change control 
    of execution. It is used to select one of many code blocks based on the value of 
    the expression. 
*/

//  Example
// switch (fruit)
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;

//     case "banana":
//         Console.WriteLine($"App will display information for banana.");
//         break;

//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }

/*
    The switch statement above is used to select one of three code blocks based on the
    value of the fruit variable. The value of the fruit variable is compared to the
    values of the case labels. If the value of the fruit variable matches the value of
    a case label, the code block following the case label is executed. The break statement
    is used to exit the switch statement after the code block is executed. If the break
    statement is not used, the code block following the matching case label will be executed
    along with all subsequent code blocks until a break statement is encountered or the end
    of the switch statement is reached.
*/

//  It is best used when you have a single value to compare against multiple values and
//  when you have a limited number of possible values to compare against.

//  Example 2
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

/*
Recap
Here's the main takeaways you learned about the switch statement:

Use the switch statement when you have one value with many possible matches, each match 
requiring a branch in your code logic. A single switch section containing code logic 
can be matched using one or more labels defined by the case keyword. Use the optional 
default keyword to create a label and a switch section that will be used when no other 
case labels match.
*/