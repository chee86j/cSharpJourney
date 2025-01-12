/*  ===CODE PROJECT 1===
Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to 
prompt the user for an integer value between 5 and 10.

Inside the iteration block:

1.  Your solution must use a Console.ReadLine() statement to obtain input from the user.
2.  Your solution must ensure that the input is a valid representation of an integer.
3.  If the integer value isn't between 5 and 10, your code must use a 
    Console.WriteLine() statement to prompt the user for an integer value between 5 and 
    10.
4.  Your solution must ensure that the integer value is between 5 and 10 before 
    exiting the iteration.
5.  Below (after) the iteration code block: your solution must use a 
    Console.WriteLine() statement to inform the user that their input value has been 
    accepted.

===EXPECTED OUTPUT:===
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/

// Console.WriteLine("Enter an integer value between 5 and 10");
//     int num = 0;
//     do
//     {
//         string input = Console.ReadLine();
//         if (int.TryParse(input, out num))
//         {
//             if (num < 5 || num > 10)
//             {
//                 Console.WriteLine("Sorry, you entered an invalid number, please try again");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         }
//     } while (num < 5 || num > 10);
//     Console.WriteLine($"Your input value ({num}) has been accepted.");

// ------------------------------------------------------------------------------------------------------------

/*  ===CODE PROJECT 2===
Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to 
prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

1.  Your solution must use a Console.ReadLine() statement to obtain input from the user.
2.  Your solution must ensure that the value entered matches one of the three role options.
3.  Your solution should use the Trim() method on the input value to ignore leading and 
    trailing space characters.
4.  Your solution should use the ToLower() method on the input value to ignore case.
5.  If the value entered isn't a match for one of the role options, your code must use a 
    Console.WriteLine() statement to prompt the user for a valid entry.
6.  Below (after) the iteration code block: your solution must use a 
    Console.WriteLine() statement to inform the user that their input value has been 
    accepted.

===EXPECTED OUTPUT:===
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     string role = "";
//     do
//     {
//         string input = Console.ReadLine().Trim().ToLower();
//         if (input == "administrator" || input == "manager" || input == "user")
//         {
//             role = input;
//         }
//         else
//         {
//             Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//         }
//     } while (role == "");
//     Console.WriteLine($"Your input value ({role}) has been accepted.");


// ------------------------------------------------------------------------------------------------------------

/*  ===CODE PROJECT 3===
1.  Use the following string array to represent the input to your coding logic:

    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", 
    "I like all three of the menu choices" };

2.  Your solution must declare an integer variable named periodLocation that can be used to hold the location of the 
    period character within a string.
3.  Your solution must include an outer foreach or for loop that can be used to process each string element in the array. 
    The string variable that you'll process inside the loops should be named myString.

4.  In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first 
    period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's 
    no period character in the string, a value of -1 will be returned.

5.  Your solution must include an inner do-while or while loop that can be used to process the myString variable.

6.  In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in 
    each of the strings that are processed.

7.  In the inner loop, your solution must not display the period character.

8.  In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string 
    information.

===EXPECTED OUTPUT:===
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    do
    {
        if (periodLocation != -1)
        {
            Console.WriteLine(myString.Substring(0, periodLocation).TrimStart());
            myString = myString.Remove(0, periodLocation + 1);
            periodLocation = myString.IndexOf(".");
        }
        else
        {
            Console.WriteLine(myString.TrimStart());
        }
    } while (periodLocation != -1);
}

