/*
Suppose you're a developer for an application letting a business update its "last chance deals" website 
by sending an email. The update email uses special required text in the title and body of the email to 
instruct the automation how to update the website. The mail includes next deal title, discount %, 
expiration, and when to publish the offer live.

Frequently, application data you need to work with is from other software systems, and has data you 
don't want or need. Sometimes the data is in an unusable format, containing extra information that 
makes the important information difficult to extract. To adjust data for your application, you need 
tools and techniques to parse through string data, isolate the information you need, and remove the 
information you don't need.

In this module, you use string helper methods to identify and isolate the information you're interested 
in. You learn how to copy a smaller portion of a larger string. You replace characters, or remove 
characters from a string.

By the end of this module, you're able to modify a string's contents, isolating specific portions to 
extract, replace, or remove.
*/

/* Example 1
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// .IndexOf(char) - returns the index of the first occurrence of the character
// .substring(startIndex, length) - returns a new string that starts at startIndex and is of length

/*
Take a minute to examine the updated code and the use of the keyword const as used in const string 
openSpan = "<span>";.

The code uses a constant with the const keyword. A constant allows you to define and initialize a 
variable whose value can never be changed. You would then use that constant in the rest of the code 
whenever you needed that value. This ensures that the value is only defined once and misspelling the 
const variable is caught by the compiler.
*/

/*
-----RECAP-----
1. IndexOf() gives you the first position of a character or string inside of another string.
2. IndexOf() returns -1 if it can't find a match.
3. Substring() returns just the specified portion of a string, using a starting position and optional 
   length.
4. There's often more than one way to solve a problem. You used two separate techniques to find all 
   instances of a given character or string.
5. Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't 
   be changed after initialization.
*/

// ----------------------------------------------------------------------------------------------------


// Example 2
/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
*/

/* 
.LastIndexOf(char) - returns the index of the last occurrence of the character
*/

/*
1. We start off with a while loop that will continue to run until we break out of it.
2. The indexOf method is used to find the position of the first opening parenthesis.
3. If there are no more opening parentheses, the indexOf method returns -1, and the loop exits.
4. If there is an opening parenthesis, the code adds 1 to the starting position.
5. The code then uses the indexOf method to find the position of the closing parenthesis.
6. Then calculates the length of the substring by subtracting the starting position from the closing position.
7. It proceeds to use the substring method to return the portion of the string that we want to work with.

*/

// Example 3

/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
*/

// IndexOfAny() - returns the index of the first occurrence of any of the characters in the array
/* 
NOTE: JavaScript requires a custom function to find the index of any of the characters in an array.

let text = "Hello, world!";
let charsToFind = ["o", "w"];

let index = [...text].findIndex(char => charsToFind.includes(char));
console.log(index); // Output: 4 ("o" appears first)

*/

/*
1. We start off with a string that we want to search through.
2. Then we define an array of characters that we want to find in the string.
3. The startPosition variable is used to specify the position in the string to start searching from.
4. The indexOfAny method is used to find the position of the first occurrence of any of the characters in the openSymbols array.
5. The substring method is used to return the portion of the string that we want to work with.
*/

/* Example 4

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

*/

// ----------------------------------------------------------------------------------------------------


/*
.Remove() - removes a specified number of characters from a string

string text = "Hello, world!";
string newText = text.Remove(5); // Removes everything from index 5 onwards
Console.WriteLine(newText); // Output: "Hello"

JavaScript: Slice()
let text = "Hello, world!";
let newText = text.slice(0, 5); // Removes everything from index 5 onwards
console.log(newText); // Output: "Hello"
*/

/*
.Replace() - replaces A SPECIFIED character with another character

string text = "Hello, world!";
string newText = text.Replace("world", "C#");
Console.WriteLine(newText); // Output: "Hello, C#!"

JavaScript: Replace() *NOTE: JavaScript reokaces ALL INSTANCES of the specified character
let text = "Hello, world!";
let newText = text.replace("world", "JavaScript");
console.log(newText); // Output: "Hello, JavaScript!"


*/