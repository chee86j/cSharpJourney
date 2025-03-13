/*
In this challenge, you work with a string that contains a fragment of HTML. You extract data from the 
HTML fragment, replace some of its content, and remove other parts of its content to achieve the 
desired output.
*/

/* Starter Code
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);
*/

/*
Expected Output:

Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

// My Solution

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Extract the quantity (number inside the <span> element)
int startSpan = input.IndexOf("<span>") + 6;
int endSpan = input.IndexOf("</span>");
quantity = "Quantity: " + input.Substring(startSpan, endSpan - startSpan);

output = input.Replace("&trade;", "&reg;"); // Replace &trade; with &reg;
output = output.Substring(5, output.Length - 11); // Remove opening and closing <div>

Console.WriteLine(quantity);
Console.WriteLine("Output: " + output);

/*
1. Two variables are initialized to hold the quantity and the output.
2. The index of the <span> element is found using the `IndexOf()` for the opening and closing tags.
3. The quantity is extracted from the input string by using the `Substring()` method.
4. The `Replace()` method is used to replace the `&trade;` with `&reg;`.
5. The `Substring()` method is used to remove the opening and closing <div> tags.
6. The `WriteLine()` method is used to display the quantity and the output.
*/

// ------------------------------------------------------------------------------------------------

/* Textbook Solution
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

*/

