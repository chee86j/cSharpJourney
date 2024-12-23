// -----Challenge-----
// To improve readability, update the code using style guidelines.
// Use the techniques that you learned in this module to make improvements to the code and increase its readability.

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

// ------------------------------------------------------------
// -----Improved Code-----

/*
    This code reverses a message, counts the number of times
    a particular character appears in the message, and then
    prints the reversed message and the count of the character.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

/* 
    This code is improved due to the following reasons:
        -Higher level descriptons of what the code is attempting to do rather than multiple comments
        -Added whitespace to make the code more readable
        -Line Feeds and tabs were added to improve the apprearance of the foreach and if statements
        -Local variables were renamed to be more descriptive to better convey each value's purpose
*/